using FluentMigrator;

namespace LivroCRUDNET.Migrations
{
    [Migration(202406031656)]
    public class FixingLivrosTable : Migration
    {
        public override void Up()
        {
            Delete.Column("ano_publicacao").FromTable("Livros");

            Alter.Table("Livros")
                .AddColumn("ano_publicacao").AsString().NotNullable();
        }

        public override void Down()
        {

        }
    }
}
