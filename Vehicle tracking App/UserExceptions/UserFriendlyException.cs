namespace Vehicle_tracking_App.UserExceptions
{
        [Serializable]
        class UserFriendlyException : Exception
        {
            public UserFriendlyException() { }

            public UserFriendlyException(string name)
                : base(String.Format(name))
            {

            }
        }
    
}
