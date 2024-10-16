using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Firestore;


namespace TransactionPackage
{
    public class Business //Manager Class
    {
        public TransactionList list { get; set; }


        private const string FIREBASE_PROJID = "cashtransaction-4ec3e"; // must be ID of your Firestore db
        private FirestoreDb db;


        public Business() { }

        public void initFirestore()
        {
            FirebaseApp.Create(); //Static Method: Belongs to the class, not an instance
            db = FirestoreDb.Create(FIREBASE_PROJID);
            Console.WriteLine("Created Cloud Firestore client with project ID: {0}", FIREBASE_PROJID);
        }

        public async Task SaveTransaction(Transaction transaction)
        {
            //Collection Reference = Predefined Class
            CollectionReference collectionRef = db.Collection("transactions");
            //DocReference = Row, Date in DateTime -> convert to String
            DocumentReference docRef = collectionRef.Document(transaction.Date.ToString());
            //Dictionary = Data Structure (To store and ref to Firestore) [KEY, VALUE]
            Dictionary<string, object> values = new Dictionary<string, object>
            {    //key              //value
                { "Id",             transaction.Val.ToString() },
                { "Date",           transaction.Date.ToString() },
                { "Employee.Name",  transaction.Employee.Name },
                { "Employee.Id",    transaction.Employee.ID }
            };

            Console.WriteLine("Adding doc with ID " + docRef.Id);
            await docRef.SetAsync(values); 
            /* Async = Asynchronous
             * Analogy: Order burger, then wait, you must do smth right?
             * Await = Wait for Cloud Access
             */
        }
    }
}

//Authentication Ref: https://cloud.google.com/docs/authentication?authuser=0#service-accounts