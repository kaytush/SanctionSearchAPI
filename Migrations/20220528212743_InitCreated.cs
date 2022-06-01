using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SanctionSearchAPI.Migrations
{
    public partial class InitCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LocalWatchlists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    full_name = table.Column<string>(maxLength: 100, nullable: true),
                    last_name = table.Column<string>(maxLength: 100, nullable: true),
                    first_name = table.Column<string>(maxLength: 100, nullable: true),
                    middle_name = table.Column<string>(maxLength: 100, nullable: true),
                    other_names = table.Column<string>(maxLength: 100, nullable: true),
                    _o__aykson_arithmos_eggrafis_ = table.Column<int>(nullable: true),
                    _proeleysi_ = table.Column<int>(nullable: true),
                    _eidos_enimerwsis_ = table.Column<string>(maxLength: 100, nullable: true),
                    _hmerominia_prosthikis_tropopoiis_ = table.Column<string>(maxLength: 100, nullable: true),
                    _morfi_ = table.Column<int>(nullable: true),
                    _kodikos_monados_ = table.Column<int>(nullable: true),
                    _syndesmos_sto_antistoixo_nomiko__ = table.Column<string>(maxLength: 100, nullable: true),
                    discovery_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    _parapompi_ = table.Column<string>(maxLength: 50, nullable: true),
                    _sxolia1_ = table.Column<string>(maxLength: 100, nullable: true),
                    _sxolia2_ = table.Column<string>(maxLength: 100, nullable: true),
                    _sxolia3_ = table.Column<string>(maxLength: 100, nullable: true),
                    sanctions_program = table.Column<string>(maxLength: 100, nullable: true),
                    _eponumo_eponumia_ = table.Column<string>(maxLength: 100, nullable: true),
                    _mikro_onoma_ = table.Column<string>(maxLength: 100, nullable: true),
                    _mesaio_onoma_ = table.Column<string>(maxLength: 100, nullable: true),
                    _oloklhro_onoma_ = table.Column<string>(maxLength: 100, nullable: true),
                    _fylo_ = table.Column<string>(maxLength: 100, nullable: true),
                    details = table.Column<string>(maxLength: 100, nullable: true),
                    _epaggelma_titlos_ = table.Column<string>(maxLength: 100, nullable: true),
                    _glwssa_ = table.Column<string>(maxLength: 100, nullable: true),
                    dieuthinsi1 = table.Column<string>(maxLength: 100, nullable: true),
                    dieuthinsi2 = table.Column<string>(maxLength: 100, nullable: true),
                    dieuthinsi3 = table.Column<string>(maxLength: 100, nullable: true),
                    _odos_ = table.Column<string>(maxLength: 100, nullable: true),
                    _arithmos_dieuthinsis_ = table.Column<string>(maxLength: 100, nullable: true),
                    tax_id = table.Column<string>(maxLength: 100, nullable: true),
                    city = table.Column<string>(maxLength: 100, nullable: true),
                    country = table.Column<string>(maxLength: 100, nullable: true),
                    _afm_ = table.Column<string>(maxLength: 100, nullable: true),
                    _kodikos1_ = table.Column<string>(maxLength: 100, nullable: true),
                    _kodikos2_ = table.Column<string>(maxLength: 100, nullable: true),
                    _kodikos3_ = table.Column<string>(maxLength: 100, nullable: true),
                    _kodikos4_ = table.Column<string>(maxLength: 100, nullable: true),
                    _arithmos_diavatiriou_ = table.Column<string>(maxLength: 100, nullable: true),
                    _xora_ekdosis_diavatiriou_ = table.Column<string>(maxLength: 100, nullable: true),
                    _yphkoothta_ = table.Column<string>(maxLength: 100, nullable: true),
                    date_birth = table.Column<DateTime>(type: "datetime", nullable: true),
                    _xora_gennhshs_ = table.Column<string>(maxLength: 50, nullable: true),
                    _topothesia_gennhshs_ = table.Column<string>(maxLength: 100, nullable: true),
                    _arithmos_nhologiou_ = table.Column<string>(maxLength: 100, nullable: true),
                    _typos_ploiou_ = table.Column<string>(maxLength: 100, nullable: true),
                    _xorhtikothta_ = table.Column<string>(maxLength: 100, nullable: true),
                    _kataxorhmenh_xorhtikothta_ = table.Column<string>(maxLength: 100, nullable: true),
                    _shmaia_ = table.Column<string>(maxLength: 100, nullable: true),
                    _ploiokthths_ = table.Column<string>(maxLength: 100, nullable: true),
                    _ethnikothta_ = table.Column<string>(maxLength: 100, nullable: true),
                    watchlist_org = table.Column<string>(maxLength: 100, nullable: true),
                    _position_ = table.Column<string>(maxLength: 100, nullable: true),
                    _length_ = table.Column<string>(maxLength: 100, nullable: true),
                    identity_type_1 = table.Column<string>(maxLength: 100, nullable: true),
                    identity_type_2 = table.Column<string>(maxLength: 100, nullable: true),
                    identity_country_1 = table.Column<string>(maxLength: 100, nullable: true),
                    identity_country_2 = table.Column<string>(maxLength: 100, nullable: true),
                    birth_country = table.Column<string>(maxLength: 100, nullable: true),
                    place_of_birth = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalWatchlists", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocalWatchlists");
        }
    }
}
