namespace TestMySQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblCliente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        matricula = c.Int(nullable: false),
                        dmatricula = c.String(nullable: false, maxLength: 10, storeType: "nvarchar"),
                        nascido = c.String(nullable: false, maxLength: 10, storeType: "nvarchar"),
                        cpf = c.String(nullable: false, maxLength: 14, storeType: "nvarchar"),
                        nome = c.String(nullable: false, maxLength: 70, storeType: "nvarchar"),
                        rg = c.String(nullable: false, maxLength: 15, storeType: "nvarchar"),
                        Exped = c.String(nullable: false, maxLength: 10, storeType: "nvarchar"),
                        Sexo = c.String(nullable: false, maxLength: 9, storeType: "nvarchar"),
                        tcel = c.String(nullable: false, maxLength: 15, storeType: "nvarchar"),
                        tfixo = c.String(nullable: false, maxLength: 14, storeType: "nvarchar"),
                        endereco = c.String(nullable: false, maxLength: 60, storeType: "nvarchar"),
                        bairro = c.String(nullable: false, maxLength: 15, storeType: "nvarchar"),
                        cidade = c.String(nullable: false, maxLength: 20, storeType: "nvarchar"),
                        estado = c.String(nullable: false, maxLength: 2, storeType: "nvarchar"),
                        statuscli = c.String(unicode: false),
                        instagran = c.String(nullable: false, maxLength: 20, storeType: "nvarchar"),
                        facebook = c.String(nullable: false, maxLength: 25, storeType: "nvarchar"),
                        email = c.String(maxLength: 25, storeType: "nvarchar"),
                        foto = c.String(unicode: false),
                        biometria = c.String(unicode: false),
                        rfacial = c.String(unicode: false),
                        colaboradorID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblColaborador", t => t.colaboradorID, cascadeDelete: true)
                .Index(t => t.colaboradorID);
            
            CreateTable(
                "dbo.tblColaborador",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        colNascimento = c.String(nullable: false, maxLength: 10, storeType: "nvarchar"),
                        colCPF = c.String(nullable: false, maxLength: 14, storeType: "nvarchar"),
                        colNome = c.String(nullable: false, maxLength: 90, storeType: "nvarchar"),
                        colRG = c.String(nullable: false, maxLength: 15, storeType: "nvarchar"),
                        colDataEXPED = c.String(nullable: false, maxLength: 10, storeType: "nvarchar"),
                        colSexo = c.String(nullable: false, maxLength: 9, storeType: "nvarchar"),
                        colTCelular = c.String(nullable: false, maxLength: 15, storeType: "nvarchar"),
                        colTFixo = c.String(nullable: false, maxLength: 14, storeType: "nvarchar"),
                        colEndereco = c.String(nullable: false, maxLength: 90, storeType: "nvarchar"),
                        colEstado = c.String(nullable: false, maxLength: 2, storeType: "nvarchar"),
                        colBairro = c.String(nullable: false, maxLength: 12, storeType: "nvarchar"),
                        colCidade = c.String(nullable: false, maxLength: 20, storeType: "nvarchar"),
                        colMatricula = c.Int(nullable: false),
                        colDMatricula = c.String(nullable: false, maxLength: 10, storeType: "nvarchar"),
                        colCargo = c.String(nullable: false, maxLength: 12, storeType: "nvarchar"),
                        colPerfil = c.String(nullable: false, maxLength: 12, storeType: "nvarchar"),
                        colNrCREF = c.String(maxLength: 10, storeType: "nvarchar"),
                        colUsuario = c.String(nullable: false, maxLength: 15, storeType: "nvarchar"),
                        colSenha = c.String(nullable: false, maxLength: 25, storeType: "nvarchar"),
                        colDtAcesso = c.String(maxLength: 10, storeType: "nvarchar"),
                        colHoAcesso = c.String(maxLength: 10, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblCliente", "colaboradorID", "dbo.tblColaborador");
            DropIndex("dbo.tblCliente", new[] { "colaboradorID" });
            DropTable("dbo.tblColaborador");
            DropTable("dbo.tblCliente");
        }
    }
}
