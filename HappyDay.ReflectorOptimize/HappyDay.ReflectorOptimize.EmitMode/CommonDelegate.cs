using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace HappyDay.ReflectorOptimize.EmitMode
{
	/// <summary>
	/// 平常的委托
	/// </summary>
	public static class PropertyAccesstorFactory
	{
		private static Dictionary<string, IPropertyAccesstor> accessorCache = new Dictionary<string, IPropertyAccesstor>();

		public static object GetValue(object instance, PropertyInfo perperty)
		{
			return FindAccessor(perperty).GetValue(instance);
		}

		public static void SetValue(object instance, PropertyInfo memberName, object newValue)
		{
			FindAccessor(memberName).SetValue(instance, newValue);
		}

		private static IPropertyAccesstor FindAccessor(PropertyInfo property)
		{
			var type = property.DeclaringType;
			var key = type.FullName + property.Name;
			IPropertyAccesstor accessor;
			accessorCache.TryGetValue(key, out accessor);
			if (accessor == null) {
				accessor = Activator.CreateInstance(typeof(PropertyAccesstor<,>).MakeGenericType(type, property.PropertyType), property) as IPropertyAccesstor;
				accessorCache.Add(key, accessor);
			}

			return accessor;
		}
	}


	public class PropertyAccesstor<F, T> : IPropertyAccesstor
	{
		private Func<F, T> getter;
		private Action<F, T> setter;

		public PropertyAccesstor(PropertyInfo property)
		{
			//getter = (Func<F, T>)Delegate.CreateDelegate(typeof(Func<F, T>), property.GetGetMethod());
			//setter = (Action<F, T>)Delegate.CreateDelegate(typeof(Action<F, T>), property.GetSetMethod());

			var declaringType = property.DeclaringType;
			var propertyType = property.PropertyType;
			var param_obj = Expression.Parameter(declaringType, "obj");
			var param_val = Expression.Parameter(propertyType, "val");
			var method = property.GetSetMethod();
			var callExpression = Expression.Call(param_obj, method, param_val);
			setter = Expression.Lambda<Action<F, T>>(callExpression, param_obj, param_val).Compile();

		}


		public void SetValue(object target, object value)
		{
			setter((F)target, (T)value);
		}

		public object GetValue(object target)
		{
			return getter((F)target);
		}
	}

	public interface IPropertyAccesstor
	{
		void SetValue(object target, object value);
		object GetValue(object target);
	}
}
