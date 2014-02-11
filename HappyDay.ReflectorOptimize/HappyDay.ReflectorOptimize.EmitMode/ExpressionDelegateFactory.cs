using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace HappyDay.ReflectorOptimize
{
	public class ExpressionDelegateFactory
	{
		private Action<F, T> GetSetValue<F, T>(PropertyInfo propertyInfo)
		{
			var declaringType = propertyInfo.DeclaringType;
			var propertyType = propertyInfo.PropertyType;
			var param_obj = Expression.Parameter(declaringType, "obj");
			var param_val = Expression.Parameter(propertyType, "val");
			var method = propertyInfo.GetSetMethod();
			var callExpression = Expression.Call(param_obj, method, param_val);

			var action = Expression.Lambda<Action<F, T>>(callExpression, param_obj, param_val).Compile();
			return action;
		}

		private Func<F, T> GetGetValue<F, T>(PropertyInfo propertyInfo)
		{
			var declaringType = propertyInfo.DeclaringType;
			var propertyType = propertyInfo.PropertyType;
			var param_obj = Expression.Parameter(declaringType, "obj");
			var param_val = Expression.Parameter(propertyType, "val");
			var method = propertyInfo.GetGetMethod();
			var callExpression = Expression.Call(param_obj, method, param_val);

			var action = Expression.Lambda<Func<F, T>>(callExpression, param_obj, param_val).Compile();
			return action;
		}

		private void SetValue(object instance, PropertyInfo propertyInfo, object value)
		{
			var declaringType = propertyInfo.DeclaringType;
			var propertyType = propertyInfo.PropertyType;
			var param_obj = Expression.Parameter(declaringType, "obj");
			var param_val = Expression.Parameter(propertyType, "val");
			var method = propertyInfo.GetSetMethod();
			var callExpression = Expression.Call(param_obj, method, param_val);

			var action = Expression.Lambda(callExpression, param_obj, param_val);
		}
	}
}
