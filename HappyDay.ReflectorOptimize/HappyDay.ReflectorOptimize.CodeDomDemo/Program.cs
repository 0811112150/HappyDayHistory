﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom;
using System.CodeDom.Compiler;

namespace HappyDay.ReflectorOptimize.CodeDomDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Program pro = new Program();
			CodeNamespace nspace = pro.CreateCodeHelloDemo();
			Console.WriteLine(pro.GengerCode(nspace));

			string filename = "HelloWorld.exe";
			CompilerResults result = pro.Execute(nspace, filename);
			if (result.Errors.HasErrors)//是否存在错误；
            {
				for (int i = 0; i < result.Output.Count; i++)

					Console.WriteLine(result.Output[i]);

				for (int i = 0; i < result.Errors.Count; i++)

					Console.WriteLine(i.ToString() + ": " + result.Errors[i].ToString());
			} else {
				System.Diagnostics.Process.Start(filename);//这里比较懒，不想动手去自己打开，呵呵；
			}
			Console.Read();
		}

		public CodeNamespace CreateCodeHelloDemo()
		{
			var method = new CodeMemberMethod();
			method.Name = "SayHello";
			method.Attributes = MemberAttributes.Public | MemberAttributes.Final;
			method.ReturnType = new CodeTypeReference(typeof(string));
			method.Statements.Add(new CodeMethodReturnStatement(new CodePrimitiveExpression("Hello From Code!")));

			CodeEntryPointMethod main = new CodeEntryPointMethod();
			main.Statements.Add(new CodeVariableDeclarationStatement("HelloWord", "hw", new CodeObjectCreateExpression("HelloWord", new CodeExpression[] { })));

			CodeMethodInvokeExpression methodInvoke = new CodeMethodInvokeExpression(new CodeVariableReferenceExpression("hw"), "SayHello",  new CodeExpression[] { });
			main.Statements.Add(new CodeMethodInvokeExpression(new CodeTypeReferenceExpression("System.Console"),"WriteLine",methodInvoke));
			main.Statements.Add(new CodeMethodInvokeExpression(new CodeTypeReferenceExpression("System.Console"), "Read"));

			CodeTypeDeclaration helloword=new CodeTypeDeclaration("HelloWord");
			helloword.Attributes=MemberAttributes.Public;
			helloword.Members.AddRange(new CodeTypeMember[]{method,main});

			CodeNamespace nspace=new CodeNamespace("HelloDemo1");
			nspace.Imports.Add(new CodeNamespaceImport("System"));

			nspace.Types.Add(helloword);
            return nspace;
		}

		public string GengerCode(CodeNamespace nspace)
		{
			StringBuilder sb = new StringBuilder();
			System.IO.StringWriter sw = new System.IO.StringWriter(sb);
			CodeGeneratorOptions geneOptions = new CodeGeneratorOptions();//代码生成选项

			geneOptions.BlankLinesBetweenMembers = false;

			geneOptions.BracingStyle = "C";

			geneOptions.ElseOnClosing = true;

			geneOptions.IndentString = "    ";
			CodeDomProvider.GetCompilerInfo("c++").CreateProvider().GenerateCodeFromNamespace(nspace, sw, geneOptions);//代码生成
			sw.Close();
			return sb.ToString();
		}

		public CompilerResults Execute(CodeNamespace nspace, string filename)
		{
			CodeCompileUnit unit = new CodeCompileUnit();//code编译单元
			unit.Namespaces.Add(nspace);
			CodeDomProvider provider = CodeDomProvider.CreateProvider("C#");
			CompilerParameters options = new CompilerParameters();//

			options.GenerateInMemory = false;//是否在内存中生成；
			options.IncludeDebugInformation = true;// 包含调试信息；
			options.ReferencedAssemblies.Add("System.dll");
			options.OutputAssembly = filename;
			if (System.IO.Path.GetExtension(filename).ToLower() == ".exe") {
				options.GenerateExecutable = true;//true为可执行exe，false：dll
			} else {
				options.GenerateExecutable = false;//true为可执行exe，false：dll
			}
			return provider.CompileAssemblyFromDom(options, unit);//编译程序集
		}

	}
}
