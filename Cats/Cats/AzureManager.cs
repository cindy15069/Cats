using Cats.DataModels;
using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cats
{
    public class AzureManager
    {

        private static AzureManager instance;
        private MobileServiceClient client;

        private IMobileServiceTable<NotCatModel> notCatTable;

        private AzureManager()
        {
            this.client = new MobileServiceClient("https://myapplicationcat.azurewebsites.net/");
            this.notCatTable = this.client.GetTable<NotCatModel>();
        }

        public MobileServiceClient AzureClient
        {
            get { return client; }
        }

        public static AzureManager AzureManagerInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AzureManager();
                }

                return instance;
            }
        }
        public async Task<List<NotCatModel>> GetCatInformation()
        {
            return await this.notCatTable.ToListAsync();
        }
    }
}
