using System;
class Question1 {
    static string toPascalCase(string str){
        if(str.Length==0){
            return "";
        }

        string newStr = "";
        int start=0;

        while(str[start]==' ' && start<str.Length){
            start++;
        }
        for(int i=start;i<str.Length;i++){
            // Console.WriteLine(str[i]);
            // newStr+=str[i];
            if(i>0 && str[i-1]==' '){
                // int tmp=i;
                while(i<str.Length && str[i]==' '){
                    i++;
                }
                if(i<str.Length){
                    if(str[i]>='a' && str[i]<='z'){
                        newStr+=(char)((str[i])-32);
                    }
                    else if(str[i]>='A' && str[i]<='Z'){
                        newStr+=str[i];
                    }
                    else if(str[i]!=' '){
                        newStr+=str[i];
                    }
                }
                else{
                    break;
                }
            }
            else{
                if(i==0 && str[i]!=' '){
                    if(str[i]>='a' && str[i]<='z'){
                        newStr+=(char)(str[i]-32);
                    }
                    else{
                        newStr+=str[i];
                    }

                }
                else if(str[i]>='A' && str[i]<='Z'){
                    newStr+=(char)(str[i]+32);
                }
                else if(str[i]!=' '){
                    newStr+=str[i];
                }
            }
        }
        return newStr;
    }
  static void Main() {
    Console.WriteLine("Hello World");
    string ans =toPascalCase("number of students");
    Console.WriteLine(ans);
    string ans1 = toPascalCase(" sefcisdjb8876 sudjsdh");
    Console.WriteLine(ans1);

    string ans2 = toPascalCase("9u0 jbjc9h hsdcj");
    Console.WriteLine(ans2);

    string ans3 = toPascalCase("NUMBER OF STUDENTS");
    Console.WriteLine(ans3);

    string ans4 = toPascalCase("iasjcb cjsd");
    Console.WriteLine(ans4);
  }
}