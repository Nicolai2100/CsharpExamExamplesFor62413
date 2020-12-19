//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Reflection;
//using System.Reflection.Emit;
//using System.Threading;

////o A DLL (assembly) with the name (Demo.dll)
////o with a default constructor
////o and one method (writing a text)
////o Dll is loaded dynamically
////o Method is fetched and called
//namespace CsExam.Examples
//{
//    public class DynamicAssemblyExample
//    {






//        // The caller sends in an AppDomain type.
//        public static void CreateMyAsm(AppDomain curAppDomain)
//        {
//            // Establish general assembly characteristics.
//            AssemblyName assemblyName = new AssemblyName();
//            assemblyName.Name = "MyAssembly";
//            assemblyName.Version = new Version("1.0.0.0");
//            // Create new assembly within the current AppDomain.

//            AssemblyBuilder assembly = AppDomain.CurrentDomain.DefineDynamicAssembly(an, AssemblyBuilderAccess.Run);



//            AssemblyBuilder assembly =
//            curAppDomain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Save);
//            // Given that we are building a single-file
//            // assembly, the name of the module is the same as the assembly.
//            ModuleBuilder module =
//            assembly.DefineDynamicModule("MyAssembly", "MyAssembly.dll");
//            // Define a public class named "HelloWorld".
//            TypeBuilder helloWorldClass = module.DefineType("MyAssembly.HelloWorld", TypeAttributes.
//            Public);
//            // Define a private String member variable named "theMessage".
//            FieldBuilder msgField =
//            helloWorldClass.DefineField("theMessage", Type.GetType("System.String"),
//            FieldAttributes.Private);
//            // Create the custom ctor.
//            Type[] constructorArgs = new Type[1];
//            constructorArgs[0] = typeof(string);
//            ConstructorBuilder constructor =
//            helloWorldClass.DefineConstructor(MethodAttributes.Public,
//            CallingConventions.Standard,
//            constructorArgs);
//            ILGenerator constructorIL = constructor.GetILGenerator();
//            constructorIL.Emit(OpCodes.Ldarg_0);
//            Type objectClass = typeof(object);

//            ConstructorInfo superConstructor = objectClass.GetConstructor(new Type[0]);
//            constructorIL.Emit(OpCodes.Call, superConstructor);
//            constructorIL.Emit(OpCodes.Ldarg_0);
//            constructorIL.Emit(OpCodes.Ldarg_1);
//            constructorIL.Emit(OpCodes.Stfld, msgField);
//            constructorIL.Emit(OpCodes.Ret);
//            // Create the default ctor.
//            helloWorldClass.DefineDefaultConstructor(MethodAttributes.Public);
//            // Now create the GetMsg() method.
//            MethodBuilder getMsgMethod =
//            helloWorldClass.DefineMethod("GetMsg", MethodAttributes.Public,
//            typeof(string), null);
//            ILGenerator methodIL = getMsgMethod.GetILGenerator();
//            methodIL.Emit(OpCodes.Ldarg_0);
//            methodIL.Emit(OpCodes.Ldfld, msgField);
//            methodIL.Emit(OpCodes.Ret);
//            // Create the SayHello method.
//            MethodBuilder sayHiMethod =
//            helloWorldClass.DefineMethod("SayHello",
//            MethodAttributes.Public, null, null);
//            methodIL = sayHiMethod.GetILGenerator();
//            methodIL.EmitWriteLine("Hello from the HelloWorld class!");
//            methodIL.Emit(OpCodes.Ret);
//            // "Bake" the class HelloWorld.
//            // (Baking is the formal term for emitting the type.)
//            helloWorldClass.CreateType();
//            // (Optionally) save the assembly to file.
//            assembly.Save("MyAssembly.dll");
//        }




//        public static void TestMethod()
//        {





//            //AppDomain theDefault = Thread.GetDomain();
//            //DynamicAssemblyExample p = new DynamicAssemblyExample();
//            //p.Baker(theDefault);
//            //Console.WriteLine("Assembly constructed..");
//            //Assembly asm = Assembly.Load("Demo");
//            //Type t = asm.GetType("Demo.DemoClass");
//            //Object o = Activator.CreateInstance(t);
//            //MethodInfo mi = t.GetMethod("WriteMsg");
//            //mi.Invoke(o, null);

//            //AppDomain theDefault = Thread.GetDomain();
//            //DynamicAssemblyExample p = new DynamicAssemblyExample();
//            //p.Baker(theDefault);
//            //Console.WriteLine("Assembly constructed..");
//            //Assembly asm = Assembly.Load("Demo");
//            //Type t = asm.GetType("Demo.DemoClass");
//            //Object o = Activator.CreateInstance(t);
//            //MethodInfo mi = t.GetMethod("WriteMsg");
//            //mi.Invoke(o, null);
//        }
//        public void Baker(AppDomain curApp)
//        {
//            //// general info
//            //AssemblyName asmName = new AssemblyName();
//            //asmName.Name = "Demo";
//            //asmName.Version = new Version("1.0.0.0");
//            // create Assembly
//            //AssemblyBuilder assembly = curApp.DefineDynamicAssembly(asmName, AssemblyBuilderAccess.Save);
//            // create a module in a single-file assembly
//            //ModuleBuilder module = assembly.DefineDynamicModule("Demo", "Demo.dll");
//            //TypeBuilder myType = module.DefineType("Demo.DemoClass", TypeAttributes.Public);
//            //myType.DefineDefaultConstructor(MethodAttributes.Public);
//            //MethodBuilder infoWriter = myType.DefineMethod("WriteMsg",
//            //MethodAttributes.Public, null, null);
//            //ILGenerator methodIl = infoWriter.GetILGenerator();
//            //methodIl.EmitWriteLine("Hi from dynamic assembly");
//            //methodIl.Emit(OpCodes.Ret);
//            //// create type and save
//            //myType.CreateType();
//            //assembly.Save("Demo.dll");
//        }
//    }
//}