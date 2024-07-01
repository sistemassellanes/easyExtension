using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EasyAccessUtil
{
    static EasyAccessUtil instance;
    public static EasyAccessUtil GetInstance()
    {
        if(instance == null)
        {
            instance = new EasyAccessUtil();    
        }
        return instance;
    }

    public string ReplaceAll(string input)
    {
        string result = input;
        if (result != null && result.Equals("") == false)
        {
            char first = result[0];

            if (first.Equals('\"'))
            {
                result = result.Substring(1, result.Length - 1);
            }

            char last = result[result.Length - 1];

            if (last.Equals('\"'))
            {
                result = result.Substring(0, result.Length - 1);
            }

            if (result.Equals("") == false)
            {
                first = result[0];

                if (first.Equals('\"'))
                {
                    result = result.Substring(1, result.Length - 1);
                }

                last = result[result.Length - 1];

                if (last.Equals('\"'))
                {
                    result = result.Substring(0, result.Length - 1);
                }
            }
        }
        return result;
    }
}

