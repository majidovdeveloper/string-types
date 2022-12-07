//literal string:
Console.WriteLine("\"Literal stirng\"");
string administration = "Hello new user! What is your name: ";
Console.Write(administration);
string name = Console.ReadLine();
Console.WriteLine($"\"{name}\" Welcome to us Website!\n");

//verbatim string:
Console.WriteLine("\"verbatim string\"");
string file_path = @"C:\televesion\newfolder\tatu.doc";
Console.WriteLine(file_path + "\n");

//String interpolation
Console.WriteLine("\"Interpolated string\"");
string administration_2 = $"\"{name}\", how old are you? ";
Console.WriteLine(administration_2);
int age;
Console.Write("Your age: ");
age = Convert.ToInt32(Console.ReadLine());
//Belgilab hammasini komentariyaga oladi 
//Ctrl + K + C / chiqaradi Ctrl + K + U

