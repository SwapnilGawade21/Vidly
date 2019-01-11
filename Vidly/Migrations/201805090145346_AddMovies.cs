namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Die Hard',1,'1/1/2000','6/12/1988',5)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Terminator',2,'2/1/2000','6/12/1988',2)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Star Wars',3,'3/1/2000','12/12/1970',3)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Batman and robin',5,'4/1/2000','6/12/1988',5)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Hulk',1,'5/1/2000','6/12/1988',1)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Pretty Women',4,'6/1/2000','6/12/1988',4)");
        }
        
        public override void Down()
        {
        }
    }
}
