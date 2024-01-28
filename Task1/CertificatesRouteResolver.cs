using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;

namespace Task1;

public class CertificatesRouteResolver : ICertificatesRouteResolver
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="input">Список нужных справок</param>
    /// <returns> Порядок в котором следует получать справки </returns>
    public IEnumerable<Certificate> GetCertificatesRoute(IEnumerable<Certificate> input)
    {
        List<Certificate> certificates = []; // список справок в порядке приобретения
        foreach (var certificate in input)
        {
            GetCertificate(certificates, certificate);
        }
        return certificates;
    }

    private static void GetCertificate(List<Certificate> certificates, Certificate official)
    {
        Stack<Certificate> stack = new([official]);
        // DFS по справкам
        while (stack.Count > 0)
        {
            var current = stack.Pop();
            // Проверка что еще нет такой справки
            if (!certificates.Contains(current))
            {
                ProcessCertificateDependencies(certificates, stack, current);
            }
        }
    }

    private static void ProcessCertificateDependencies(List<Certificate> certificates, Stack<Certificate> stack, Certificate current)
    {
        // Находим все необходимые справки которых у нас еще нет
        stack.Push(current);
        var count = stack.Count;
        foreach (var dep in current.Prerequisites)
        {
            // Добавляем необходимые справки
            if (!certificates.Contains(dep))
            {
                stack.Push(dep);
            }
        }
        // Если ничего не было добавлено
        if (stack.Count == count)
        {
            stack.Pop();
            certificates.Add(current);
        }
    }
}

