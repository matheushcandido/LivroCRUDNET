using FluentMigrator;

namespace LivroCRUDNET.Migrations
{
    [Migration(202406031627)]
    public class FirstMigration : Migration
    {
        public override void Up()
        {
            Create.Table("Livros")
                .WithColumn("id").AsGuid().PrimaryKey().WithDefault(SystemMethods.NewGuid)
                .WithColumn("titulo").AsString(255).NotNullable()
                .WithColumn("autor").AsString(255).NotNullable()
                .WithColumn("ano_publicacao").AsDate().NotNullable()
                .WithColumn("genero_id").AsGuid().NotNullable();

            Create.Table("Generos")
                .WithColumn("id").AsGuid().PrimaryKey().WithDefault(SystemMethods.NewGuid)
                .WithColumn("nome").AsString(255).NotNullable();
        }

        public override void Down()
        {

        }
    }
}
