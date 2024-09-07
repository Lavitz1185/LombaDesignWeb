using System.Reflection;

namespace OlehOlehNTT.Infrastructure;

public static class AssemblyReference
{
    public static Assembly Assembly => typeof(AssemblyReference).Assembly;
}
