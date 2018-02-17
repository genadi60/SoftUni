using System;
using System.Collections.Generic;
using System.Linq;

class File
{
    public string Root { get; set; }
    public string Path { get; set; }
    public string Name { get; set; }
    public string Extension { get; set; }
    public long Size { get; set; }
}
public class Files
{


    public static void Main()
    {
        var outputList = new List<File>();
        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine();
            if (input.Equals(string.Empty))
            {
                continue;
            }
            var rootiIndex = input.IndexOf("\\");
            var root = ExtractRoot(input, rootiIndex);
            var pathIndex = input.IndexOf(";");
            var path = ExtractPath(input, pathIndex);
            var size = ExtractSize(input, pathIndex);
            var extIndex = input.LastIndexOf(".");
            var ext = ExtractExtension(input, extIndex, pathIndex);
            var name = ExtractName(input, pathIndex);
            var file = new File
            {
                Root = root,
                Path = path,
                Name = name,
                Extension = ext,
                Size = size
            };
            bool x = false;
            bool y = false;
            if (outputList.Count == 0)
            {
                outputList.Add(file);
            }
            foreach (var f in outputList)
            {
                if (f.Path == file.Path && f.Name == file.Name && f.Extension == file.Extension)
                {
                    f.Size = file.Size;
                    x = true;
                }
                if (f.Path != file.Path || f.Name != file.Name || f.Extension != file.Extension)
                {
                    y = true;
                }
            }
            if (y && !x)
            {
                outputList.Add(file);
            }
        }
        var targetInput = Console.ReadLine();
        if (targetInput.Length == 0)
        {
            Console.WriteLine("No");
            return;
        }
        var target = targetInput
            .Split(' ')
            .ToArray();
        if (target.Length != 3)
        {
            Console.WriteLine("No");
            return;
        }
        var rootTarget = target[2];
        var extensionTarget = target[0];
        outputList = outputList
            .Where(x => x.Root.Equals(rootTarget))
            .Where(x => x.Extension.Equals(extensionTarget))
            .OrderByDescending(x => x.Size)
            .ThenBy(x => x.Name)
            .ToList();
        if (outputList.Count > 0)
        {
            foreach (var f in outputList)
            {
                Console.WriteLine($"{f.Name} - {f.Size} KB ");
            }
        }
        else
        {
            Console.WriteLine("No");
        }
    }
    
    static string ExtractRoot(string fileData, int rootiIndex)
    {
        var root = "";
        if (rootiIndex >= 0)
        {
           root = fileData.Substring(0, rootiIndex);
        }
        return root;
    }

    static string ExtractExtension(string fileData, int extIndex, int pathIndex)
    {
        var ext = "";
        if (extIndex >= 0 && pathIndex >= 0)
        {
            ext = fileData.Substring(extIndex + 1, pathIndex - extIndex - 1);
        }
        return ext;
    }

    static long ExtractSize(string fileData, int pathIndex)
    {
        long size = 0;
        if (pathIndex >= 0)
        {
            size = long.Parse(fileData.Substring(pathIndex + 1));
        }
        return size;
    }

    static string ExtractPath(string fileData, int pathIndex)
    {
        var path = "";
        if (pathIndex >= 0)
        {
            path = fileData.Substring(0, pathIndex);
        }
        return path;
    }

    static string ExtractName(string fileData, int pathIndex)
    {
        var nameIndex = fileData.LastIndexOf("\\");
        var name = "";
        if (nameIndex >= 0)
        {
            name = fileData.Substring(nameIndex + 1, pathIndex - nameIndex - 1);
        }
        return name;
    }
}