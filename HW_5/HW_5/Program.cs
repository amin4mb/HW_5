
string sourceFile = "File.txt";
FileInfo fileinfo = new FileInfo(sourceFile);
var DirectotySourcs = fileinfo.Directory.Parent.Parent.Parent.ToString();
string destinationFile = Path.Combine(DirectotySourcs, @"Archive\filecopy.txt");
//string  destinationFile = "";
try
{
    File.Copy(sourceFile, destinationFile);
    Console.WriteLine("copy is complated");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
catch (IOException iox)
{
    Console.WriteLine(iox.Message);
}



