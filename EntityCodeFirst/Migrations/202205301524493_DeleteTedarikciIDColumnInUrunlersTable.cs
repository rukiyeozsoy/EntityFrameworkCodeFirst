namespace EntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteTedarikciIDColumnInUrunlersTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Urunlers", "TedarikciID", "dbo.Tedarikcilers");
            DropIndex("dbo.Urunlers", new[] { "TedarikciID" });
            RenameColumn(table: "dbo.Urunlers", name: "TedarikciID", newName: "Tedarikciler_TedarikciID");
            AlterColumn("dbo.Urunlers", "Tedarikciler_TedarikciID", c => c.Int());
            CreateIndex("dbo.Urunlers", "Tedarikciler_TedarikciID");
            AddForeignKey("dbo.Urunlers", "Tedarikciler_TedarikciID", "dbo.Tedarikcilers", "TedarikciID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Urunlers", "Tedarikciler_TedarikciID", "dbo.Tedarikcilers");
            DropIndex("dbo.Urunlers", new[] { "Tedarikciler_TedarikciID" });
            AlterColumn("dbo.Urunlers", "Tedarikciler_TedarikciID", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Urunlers", name: "Tedarikciler_TedarikciID", newName: "TedarikciID");
            CreateIndex("dbo.Urunlers", "TedarikciID");
            AddForeignKey("dbo.Urunlers", "TedarikciID", "dbo.Tedarikcilers", "TedarikciID", cascadeDelete: true);
        }
    }
}
