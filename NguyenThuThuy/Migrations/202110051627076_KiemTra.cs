namespace NguyenThuThuy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KiemTra : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SinhVien", "HoTen", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SinhVien", "HoTen", c => c.Int(nullable: false));
        }
    }
}
