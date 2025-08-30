using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalTest.Models;
using FinalTest.Views;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using System.Data;
using System.IO;
using static System.Windows.Forms.LinkLabel;

namespace FinalTest.Repositories
{
    public class FavouriteController : IFavouriteController
    {
        



        public IList<FavouriteModel> GetFavourites(string filePath)
        {
            var favourites = new List<FavouriteModel>();

            try
            {
                // Read all lines from the text file
                var lines = File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    // Assuming each line is in the format "Id,Name,URL"
                    var parts = line.Split(',');

                    if (parts.Length >= 3 && !string.IsNullOrWhiteSpace(parts[1])) // Check that Name is not empty
                    {
                        FavouriteModel favourite = new FavouriteModel
                        {
                            Id = int.Parse(parts[0]), // Parse Id
                            Name = parts[1], // Assign Name
                            Url = parts[2] // Assign URL
                        };

                        favourites.Add(favourite);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            return favourites;
        }


       

        public FavouriteModel? GetFavourite(string filePath, int id)
        {
            try
            {
                // Read all lines from the text file
                var lines = File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    // Assuming each line is in the format "Id,Name,URL"
                    var parts = line.Split(',');

                    if (parts.Length >= 3 && int.TryParse(parts[0], out int currentId) && currentId == id)
                    {
                        // Create and return the FavouriteModel if the ID matches
                        return new FavouriteModel
                        {
                            Id = currentId,
                            Name = parts[1],
                            Url = parts[2]
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

        public void AddFavourite(string filePath, FavouriteModel favourite)
        {
            int Id = 0;
            string lastLine = File.ReadLines("Favourites.txt").LastOrDefault();

            string firstWord = GetLastId(lastLine);

            int id = int.Parse(firstWord);

            Id = id;
            Id++;

            try
            {
                // Prepare the line to be written, assuming the format is "Name,URL"
                string line = $"{Id},{favourite.Name},{favourite.Url}";

                // Append the line to the text file
                File.AppendAllText(filePath, line + Environment.NewLine);

                MessageBox.Show("Favourite added.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        public void DeleteFavourite(int id)
        {
            

            try
            {
                // Read all lines from the text file
                var lines = File.ReadAllLines("Favourites.txt").ToList();

                // Filter out the line with the matching ID
                var updatedLines = lines.Where(line =>
                {
                    var parts = line.Split(',');
                    return parts.Length < 1 || !int.TryParse(parts[0], out int currentId) || currentId != id;
                }).ToList();

                // Write the remaining lines back to the file
                File.WriteAllLines("Favourites.txt", updatedLines);

                MessageBox.Show("Favourite deleted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        public void EditFavourite(FavouriteModel favourite)
        {

            try
            {
                // Read all lines from the text file
                var lines = File.ReadAllLines("Favourites.txt").ToList();

                // Find the index of the line to update based on the ID
                for (int i = 0; i < lines.Count; i++)
                {
                    var parts = lines[i].Split(',');
                    if (parts.Length >= 3 && int.TryParse(parts[0], out int currentId) && currentId == favourite.Id)
                    {
                        // Update the line with new values
                        lines[i] = $"{favourite.Id},{favourite.Name},{favourite.Url}";
                        break; // Exit loop after updating
                    }
                }


                // Write the updated lines back to the file
                File.WriteAllLines("Favourites.txt", lines);

                MessageBox.Show("Favourite updated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

    }
}
