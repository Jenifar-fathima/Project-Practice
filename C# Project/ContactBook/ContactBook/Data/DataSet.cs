namespace ContactBook.Data
{
    internal static class DataSet
    {
        #region Fields
        private static readonly List<Contact> contactInfo = new();
        #endregion

        #region Internals
        internal static void Add(Contact contactObj)
        {
            contactInfo.Add(contactObj);
        }

        internal static void Remove(Contact contactObj)
        {
            contactInfo.Remove(contactObj);
        }

        internal static Contact? FindByEmail(string strEmail)
        {
            return contactInfo.FirstOrDefault(c => c.Email == strEmail);
        }

        internal static string GetAll()
        {
            string strResult = string.Empty;

            foreach (Contact contact in contactInfo)
            {
                strResult += $"Name: {contact.Name},  Email: {contact.Email}, Contact Number: {contact.ContactNumber}\n";
            }

            return strResult;
        }
        #endregion
    }
}