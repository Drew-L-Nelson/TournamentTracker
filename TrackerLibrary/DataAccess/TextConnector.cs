using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;
using System.Runtime.CompilerServices;

namespace TrackerLibrary.DataAccess
{
    // TODO - Wire up the CreatePrize for text files
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizesModels.csv";
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Load the text file and convert the text to List<PrizeModel>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            // Find the max ID
            int currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            model.Id = currentId;

            // Add the new record with the new ID (max + 1)
            prizes.Add(model);
            
            
            
            // Convert the prizes to a list<string>
            // Save the list<string> to the text file


        }
    }
}
