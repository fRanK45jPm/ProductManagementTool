namespace Application.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class initialuserdata : DbMigration
    {
        public override void Up()
        {
            this.Sql("INSERT INTO [dbo].[User] ([Environment],[Username],[IsSuperUser],[ApiToken]) VALUES (100001,'test.admin.user',1,'CB12B7D4-6975-48CE-B115-6FC0C317F064')");
            this.Sql("INSERT INTO [dbo].[User] ([Environment],[Username],[IsSuperUser],[ApiToken]) VALUES (100002,'test.admin.user',1,'4E1C41E3-DFDF-4041-9224-E8D6AA9B59DB')");
            this.Sql("INSERT INTO [dbo].[User] ([Environment],[Username],[IsSuperUser],[ApiToken]) VALUES (100003,'test.admin.user',1,'4B747EBF-D925-4761-B42B-6AA68B00CD66')");
        }

        public override void Down()
        {
            this.Sql("delete from  [dbo].[User] where username = 'test.admin.user'");
        }
    }
}
