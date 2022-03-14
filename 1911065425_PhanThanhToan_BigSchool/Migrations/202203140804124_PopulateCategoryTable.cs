namespace _1911065425_PhanThanhToan_BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (id,NAME) VALUES (1, 'Development')");
            Sql("INSERT INTO CATEGORIES (id,NAME) VALUES (2, 'Business')");
            Sql("INSERT INTO CATEGORIES (id,NAME) VALUES (3, 'Maketing')");
        }
        
        public override void Down()
        {
        }
    }
}
