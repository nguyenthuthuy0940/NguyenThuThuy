namespace NguyenThuThuy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LopHoc",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MaLop = c.Int(nullable: false),
                        TenLop = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SinhVien",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MaSinhVien = c.Int(nullable: false),
                        HoTen = c.Int(nullable: false),
                        MaLop = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SinhVien");
            DropTable("dbo.LopHoc");
        }
    }
}
