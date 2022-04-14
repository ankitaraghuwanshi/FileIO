namespace FileIo
{
    class program
    {
        public static void fileExist()
        {
            string txtFile = @"C:\Users\Lenovo\Documents\question.txt";
            if (File.Exists(txtFile))
                Console.WriteLine("file exist");
            else
                Console.WriteLine("file not exist");
        }
        public static void ReadfilebyLine()
        {
            string txtFile = @"C:\Users\Lenovo\Documents\question.txt";
            using (StreamReader read = File.OpenText(txtFile))
            {
                string s = "";
                while ((s = read.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                read.Close();
            }
        }

        public static void ReadAllText()
        {
            string txtFile = @"C:\Users\Lenovo\Documents\question.txt";
            string testData = File.ReadAllText(txtFile);

        }

        public static void ReadAllBytes()
        {
            string txtFile = @"C:\Users\Lenovo\Documents\question.txt";
            byte[] testDataRawBytes = File.ReadAllBytes(txtFile);
            foreach (byte b in testDataRawBytes)
                Console.WriteLine(b);



        }

        public static void AddingText()
        {

            string txtFile = @"C:\Users\Lenovo\Documents\question.txt";
            string AddData = "Hello i am ankita";
            File.WriteAllText(txtFile, AddData);

        }
        public static void AppendingText()
        {
            string txtFile = @"C:\Users\Lenovo\Documents\question.txt";
            string data = "Writing the program";
            File.AppendAllText(txtFile, data);
        }
        public static void AppendingTextbylines()
        {
            string filePath = @"C:\Users\Lenovo\Documents\question.txt";
            string[] otherData = { "Working in C#", "lives in MP" };
            File.AppendAllLines(filePath, otherData);

        }


        public static void Copyfile()
        {
            string txtFile = @"C:\Users\Lenovo\Documents\question.txt";
            string txtFileCopy = @"C:\Users\Lenovo\Documents\question.txt1";
            File.Copy(txtFile, txtFileCopy);
            Console.ReadKey();
        }

        public static void Deletefile()
        {
            string txtFileCopy = @"C:\Users\Lenovo\Documents\question.txt1";
            File.Delete(txtFileCopy);
            Console.ReadKey();
        }
        public static void TimeOfCreation()
        {
            string txtFile = @"C:\Users\Lenovo\Documents\question.txt";
            DateTime fileCreatedOn = File.GetCreationTime(txtFile);
            Console.WriteLine(fileCreatedOn);
        }
        public static void CopyInNewDirectory()
        {
            string txtFile = @"C:\Users\Lenovo\Documents\question.txt";
            string destinationFilePath = @"D:\temp\abc.txt";
            bool overwrite = true;
            FileInfo fInfo = new FileInfo(txtFile);
            fInfo.CopyTo(destinationFilePath, overwrite);
        }

        public void DirectoryName()
        {
            string sourceFilePath = @"C:\Users\Lenovo\Documents\question.txt";
            FileInfo fInfo = new FileInfo(sourceFilePath);
            string directoryPath = fInfo.DirectoryName;
            Console.WriteLine(directoryPath);

        }
        public void FileExist()
        {
            string sourceFilePath = @"C:\Users\Lenovo\Documents\question.txt";
            FileInfo fInfo = new FileInfo(sourceFilePath);
            bool filesExists = fInfo.Exists;
            Console.WriteLine(filesExists);
        }
        public void FileExtension()
        {
            string sourceFilePath = @"C:\Users\Lenovo\Documents\question.txt";
            FileInfo fInfo = new FileInfo(sourceFilePath);
            string filesExtn = fInfo.Extension;
            Console.WriteLine("File Extension is : " + filesExtn);
        }
        public void FileLength()
        {
            string sourceFilePath = @"C:\Users\Lenovo\Documents\question.txt";
            FileInfo fInfo = new FileInfo(sourceFilePath);
            long length = fInfo.Length;
            Console.WriteLine("file length is : " + length);
        }
        public void CreateDirectory()
        {
            string sourceDirPath = @"D:\MyData\Data";
            Directory.CreateDirectory(sourceDirPath);
        }
        public void DeleteDirectory()
        {
            string sourceDirPath = @"D:\MyData\Data";
            bool deleteRecursively = true;
            Directory.Delete(sourceDirPath, deleteRecursively);
        }
        public void ExistDirectory()
        {
            string sourceDirPath = @"D:\MyData\Data";
            bool tempDataDirectoryExists = Directory.Exists(sourceDirPath);
            Console.WriteLine(tempDataDirectoryExists);
        }
        public void GetDirectory()
        {
            string txtFile = @"D:\";
            string[] subDirectories = Directory.GetDirectories(txtFile);
            foreach (string subDirectory in subDirectories)
            {
                Console.WriteLine(subDirectory);
            }
        }
        public void GetFiles()
        {
            string sourceDirPath = @"D:\temp\";
            string[] files = Directory.GetFiles(sourceDirPath);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
        }
        public static void Main(string[] args)
        {
            program program = new program();
            Console.WriteLine("select option");
            int option;
            do
            {
                Console.WriteLine("Enter 1 to check file exist");
                Console.WriteLine("Enter 2 to Read text by line");
                Console.WriteLine("Enter 3 to Read all Text ");
                Console.WriteLine("Enter 4 to Read text in binary");
                Console.WriteLine("Enter 5 to Add text in the file ");
                Console.WriteLine("Enter 6 to Append text in the file ");
                Console.WriteLine("Enter 7 to Append line by line ");
                Console.WriteLine("Enter 8 to copy the file ");
                Console.WriteLine("Enter 9 to delete the file ");
                Console.WriteLine("Enter 10 to know creation time of the file ");
                Console.WriteLine("Enter 11 to copy file in another directory ");
                Console.WriteLine("Enter 12 to know DirectoryName");
                Console.WriteLine("Enter 13 to know FileExist");
                Console.WriteLine("Enter 14 for FileExtension");
                Console.WriteLine("Enter 15 for FileLength");
                Console.WriteLine("Enter 16 for CreateDirectory");
                Console.WriteLine("Enter 17 for DeleteDirectory");
                Console.WriteLine("Enter 18 for ExistDirectory");
                Console.WriteLine("Enter 19 for GetDirectory");
                Console.WriteLine("Enter 20 for GetFiles");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine(" the file exist");
                        fileExist();
                        break;
                    case 2:
                        Console.WriteLine(" read line by line ");
                        ReadfilebyLine();
                        break;
                    case 3:
                        Console.WriteLine("read all text ");
                        ReadAllText();
                        break;
                    case 4:
                        Console.WriteLine("file in binary ");
                        ReadAllBytes();
                        break;
                    case 5:
                        Console.WriteLine("text added");
                        AddingText();
                        break;
                    case 6:
                        AppendingText();
                        break;
                    case 7:
                        AppendingTextbylines();
                        break;
                    case 8:
                        Copyfile();
                        break;
                    case 9:
                        Deletefile();
                        break;
                    case 10:
                        TimeOfCreation();
                        break;
                    case 11:
                        CopyInNewDirectory();
                        Console.WriteLine("check it is created");
                        break;

                    case 12:
                        program.DirectoryName();
                        break;
                    case 13:
                        program.FileExist();
                        break;
                    case 14:
                        program.FileExtension();
                        break;
                    case 15:
                        program.FileLength();
                        break;
                    case 16:
                        program.CreateDirectory();
                        break;
                    case 17:
                        program.DeleteDirectory();
                        break;
                    case 18:
                        program.ExistDirectory();
                        break;
                    case 19:
                        program.GetDirectory();
                        break;
                    case 20:
                        program.GetFiles();
                        break;
                    case 0:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Envalid choice");
                        break;
                }


            } while (option != 0);

        }

    }
}



    
