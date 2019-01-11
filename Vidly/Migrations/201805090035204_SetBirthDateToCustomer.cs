namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetBirthDateToCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = '11/11/2000' where Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
