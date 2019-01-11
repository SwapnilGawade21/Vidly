namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2c2dcb39-f78c-4f35-8ce7-222347ad8c18', N'admin@vidly.com', 0, N'AKISYIMT4he/LTXgVIhISOSC0qGcEjTmTTvt+ZGXnBKYJflD+uw8hrDSsvR/pI96oA==', N'87e622d7-046b-4d59-8a8a-641b8e753844', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'70aab19e-8ff0-4a14-a475-b068e589631f', N'guest@vidly.com', 0, N'AFnhNRHdalzO4LIK5QfVN7n3pjfLihlp5bTS78S2QoULvcntZnOpLt/3s0tf/QxDgQ==', N'178dce0d-c870-4479-b259-ec6555e7370e', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'7453be5c-097e-4613-8e42-eb7ed26da6af', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2c2dcb39-f78c-4f35-8ce7-222347ad8c18', N'7453be5c-097e-4613-8e42-eb7ed26da6af')
");
        }
        
        public override void Down()
        {
        }
    }
}
