using FinalTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace FinalTest.Repositories
{
    public class HistoryController : IHistoryController
    {
        //string historyPath = Path.Combine(Application.StartupPath, "history.txt");

        public List<HistoryModel> GetHistory(string filePath)
        {
            var histories = new List<HistoryModel>();

            try
            {
                // Read all lines from the text file
                var lines = File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    // Assuming each line is in the format "Id,URL"
                    var parts = line.Split(',');

                    if (parts.Length >= 2) // Ensure there are at least two parts
                    {
                        HistoryModel history = new HistoryModel();
                        history.Id = int.Parse(parts[0]); // Parse Id
                        history.Url = parts[1]; // Assign URL
                        histories.Add(history);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            return histories;
        }


       


        public HistoryModel? SearchHistory(string filePath, int id)
        {
            try
            {
                // Read all lines from the text file
                var lines = File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    // Assuming each line is in the format "Id,URL"
                    var parts = line.Split(',');

                    if (parts.Length >= 2 && int.TryParse(parts[0], out int currentId) && currentId == id)
                    {
                        // Create and return the HistoryModel if the ID matches
                        return new HistoryModel
                        {
                            Id = currentId,
                            Url = parts[1]
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            return null; // Return null if no match is found
        }

        public void ClearHistory(string filePath)
        {
            try
            {
                // Clear the contents of the file by writing an empty array
                File.WriteAllLines(filePath, Array.Empty<string>());

                MessageBox.Show("History cleared.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private static string GetLastId(string lastLine)
        {
            // Split the line by whitespace and take the first element
            //check if the list is empty
            if (lastLine != null)
            {
                var words = lastLine.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                return words.Length > 0 ? words[0] : string.Empty; // Return the first word or an empty string if there are no words

            }
            else
            {

                return "0";
            }

        }

        public void AddHistory(string filePath, HistoryModel history)
        {
            
                int Id = 0;
            string lastLine = File.ReadLines("History.txt").LastOrDefault();

            string firstWord = GetLastId(lastLine);

            int id = int.Parse(firstWord);

            Id = id;
            Id++;

            try
                {
                    // Prepare the line to be written, assuming the format is "Name,URL"
                    string line = $"{Id},{history.Url}";

                    // Append the line to the text file
                    File.AppendAllText(filePath, line + Environment.NewLine);

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            
        }




    }
}
