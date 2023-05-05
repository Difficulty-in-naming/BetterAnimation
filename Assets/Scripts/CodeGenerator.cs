using System.Collections.Generic;
using System.Text;

/// <summary>
/// 生成C#代码的工具
/// </summary>
public class CodeGenerator
{
    public StringBuilder GenerateCode(Class mainClass)
    {
        return GenerateCode(mainClass, 0);
    }
    
    private StringBuilder GenerateCode(Class classObj, int indentLevel)
    {
        StringBuilder code = new StringBuilder();

        GenerateClassDeclaration(classObj, code, indentLevel);

        foreach (var variable in classObj.Variables)
        {
            code.AppendLine(
                $"{GetIndent(indentLevel + 1)}{variable.Modifier.ToString().ToLower()}{(variable.Defined != null ? " " + variable.Defined.ToString().ToLower() : "")} {variable.Type} {variable.Name}{(variable.DefaultValue != null ? $" = {variable.DefaultValue}" : "")};");
        }

        foreach (var method in classObj.Methods)
        {
            GenerateMethodDeclaration(method, code, indentLevel + 1);
        }

        foreach (var nestedClass in classObj.NestedClasses)
        {
            code.Append(GenerateCode(nestedClass, indentLevel + 1));
        }

        code.AppendLine($"{GetIndent(indentLevel)}}}\n");

        return code;
    }

    private void GenerateClassDeclaration(Class classObj, StringBuilder code, int indentLevel)
    {
        code.AppendLine(
            $"{GetIndent(indentLevel)}{classObj.Attribute.Modifier.ToString().ToLower()}{(classObj.Attribute.Type != null ? " " + classObj.Attribute.Type.ToString().ToLower() : "")} class {classObj.ClassName}");
        bool isAppend = false;
        if (!string.IsNullOrEmpty(classObj.Attribute.BaseClass))
        {
            isAppend = true;
            code.Append(":" + classObj.Attribute.BaseClass);
        }

        if (classObj.Attribute.ImplementedInterfaces.Count > 0)
        {
            code.Append(!isAppend ? ":" : ",");
            int count = classObj.Attribute.ImplementedInterfaces.Count;
            for (var index = 0; index < count; index++)
            {
                var node = classObj.Attribute.ImplementedInterfaces[index];
                if (index < count - 2)
                    code.Append(node + ",");
                else
                    code.Append(node);
            }
        }
        code.AppendLine($"{GetIndent(indentLevel)}{{");
    }

    private void GenerateMethodDeclaration(Method method, StringBuilder code, int indentLevel)
    {
        code.AppendLine();
        code.AppendLine(
            $"{GetIndent(indentLevel)}{method.Attribute.Modifier.ToString().ToLower()}{(method.Attribute.Defined != null ? " " + method.Attribute.Defined.ToString().ToLower() : "")}{(string.IsNullOrEmpty(method.ReturnType) ? "" : " " + method.ReturnType)} {method.Name}({string.Join(", ", GenerateParameters(method.Parameters))})");
        code.AppendLine($"{GetIndent(indentLevel)}{{");
        code.Append(GenerateMethodBody(method, indentLevel + 1));
        code.AppendLine($"{GetIndent(indentLevel)}}}");
    }

    private List<string> GenerateParameters(List<Parameter> parameters)
    {
        List<string> parameterStrings = new List<string>();

        foreach (var parameter in parameters)
        {
            string parameterString = "";

            if (parameter.IsThis)
            {
                parameterString += "this ";
            }
            else if (parameter.IsRef)
            {
                parameterString += "ref ";
            }
            else if (parameter.IsOut)
            {
                parameterString += "out ";
            }
            else if (parameter.IsParams)
            {
                parameterString += "params ";
            }

            parameterString += $"{parameter.Type} {parameter.Name}";

            if (parameter.IsOptional)
            {
                parameterString += $" = {parameter.DefaultValue}";
            }

            parameterStrings.Add(parameterString);
        }

        return parameterStrings;
    }

    private string GenerateMethodBody(Method method, int indentLevel)
    {
        StringBuilder body = new StringBuilder();
        body.AppendLine($"{GetIndent(indentLevel)}{method.Body}");
        return body.ToString();
    }

    /// <summary>
    /// 获取指定缩进级别的空格字符串
    /// </summary>
    /// <param name="indentLevel">缩进级别</param>
    /// <returns>空格字符串</returns>
    private string GetIndent(int indentLevel)
    {
        return new string(' ', indentLevel * 4);
    }
}

public enum AccessModifier
{
    Public,
    Private,
    Protected,
    Internal
}

public enum ClassType
{
    None,
    Sealed,
    Abstract,
    Static
}

public enum MethodModifier
{
    Static,
    Virtual,
    Override,
    Abstract,
    Sealed,
    New,
    Async,
    Unsafe,
    Extern,
    Internal,
    Public,
    Private,
    Protected
}

public enum VariableModifier
{
    Static,
    ReadOnly,
    Volatile,
    Unsafe,
    Fixed,
    Const
}

public class ClassAttribute
{
    public readonly ClassType? Type = null;
    public string BaseClass = null;
    public List<string> ImplementedInterfaces = new List<string>();
    public readonly AccessModifier Modifier = AccessModifier.Public;
}

public class MethodAttribute
{
    public MethodModifier? Defined = null;
    public AccessModifier Modifier = AccessModifier.Public;
}

public class Variable
{
    public readonly string Name;
    public readonly string Type;
    public string DefaultValue;
    public AccessModifier Modifier = AccessModifier.Public;
    public VariableModifier? Defined = null;

    public Variable(string name, string type)
    {
        Name = name;
        Type = type;
        DefaultValue = null;
    }
}

public class Parameter
{
    public readonly string Name;
    public readonly string Type;
    public readonly string DefaultValue;
    public readonly bool IsRef = false;
    public readonly bool IsOut = false;
    public readonly bool IsParams = false;
    public readonly bool IsThis = false;
    public readonly bool IsOptional = false;

    public Parameter(string name, string type)
    {
        Name = name;
        Type = type;
        DefaultValue = null;
    }
}

public class Method
{
    public readonly string Name;
    public string ReturnType;
    public readonly string Body;
    public readonly MethodAttribute Attribute;
    public readonly List<Parameter> Parameters;

    public Method(string name, string returnType, string body)
    {
        Name = name;
        ReturnType = returnType;
        Body = body;
        Attribute = new MethodAttribute();
        Parameters = new List<Parameter>();
    }

    public void AddParameter(Parameter parameter)
    {
        Parameters.Add(parameter);
    }
}

public class Class
{
    public readonly string ClassName;
    public readonly ClassAttribute Attribute;
    public readonly List<Variable> Variables;
    public readonly List<Method> Methods;
    public readonly List<Class> NestedClasses;

    public Class(string className)
    {
        ClassName = className;
        Attribute = new ClassAttribute();
        Variables = new List<Variable>();
        NestedClasses = new List<Class>();
        Methods = new List<Method>();
    }

    public void AddVariable(Variable variable)
    {
        Variables.Add(variable);
    }

    public void AddMethod(Method method)
    {
        Methods.Add(method);
    }
    
    public void AddClass(Class @class)
    {
        NestedClasses.Add(@class);
    }
}