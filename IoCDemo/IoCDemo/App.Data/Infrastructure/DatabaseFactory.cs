namespace App.Data.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private ApplicationDBContext dataContext;
        public ApplicationDBContext Get()
        {
            return dataContext ?? (dataContext = new ApplicationDBContext());
        }
        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
}
