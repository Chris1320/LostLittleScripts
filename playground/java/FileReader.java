import java.io.IOException;
import java.nio.charset.StandardCharsets;
import java.nio.file.Path;
import java.util.Scanner;

public class FileReader
{
    public static void main(String[] args)
    {
        var user_input = new Scanner(System.in);
        String filepath;

        System.out.print("Enter a filename: ");  // Ask user for a filepath.
        filepath = user_input.nextLine();

        System.out.println("Reading file `" + filepath + "`...");
        try
        {
            // Open file located in filepath with UTF-8 encoding.
            var file_obj = new Scanner(Path.of(filepath), StandardCharsets.UTF_8);

            System.out.println("Reading file contents...");
            System.out.println("=".repeat(40));

            while (file_obj.hasNext())  // Read file contents
            {
                System.out.println(file_obj.nextLine());
            }
            System.out.println("=".repeat(40));
        }
        catch (IOException e)
        {
            System.out.println("[Cannot read file!] " + e.getMessage());
            return;
        }
        finally
        {
            user_input.close();
        }
    }
}
