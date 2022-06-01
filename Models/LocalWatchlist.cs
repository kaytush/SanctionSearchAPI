using System;
using System.Collections.Generic; 
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
namespace SanctionSearchAPI.Models
{
    public class LocalWatchlist
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [DisplayName("Full Name")]
        [StringLength(100)]
        public string full_name { get; set; }
        [DisplayName("Last Name")]
        [StringLength(100)]
        public string last_name { get; set; }
        [DisplayName("First Name")]
        [StringLength(100)]
        public string first_name { get; set; }
        [DisplayName("Middle Name")]
        [StringLength(100)]
        public string middle_name { get; set; }
        [DisplayName("Other Names")]
        [StringLength(100)]
        public string other_names { get; set; }
        [DisplayName("Aykson_Arithmos_Eggrafis")]
        public int? _o__aykson_arithmos_eggrafis_ { get; set; }
        [DisplayName("Organisation")]
        public int? _proeleysi_ { get; set; }
        [DisplayName("Eidos Enimerwsis")]
        [StringLength(100)]
        public string _eidos_enimerwsis_ { get; set; }
        [DisplayName("Hmerominia Prosthikis Tropopoiis")]
        [StringLength(100)]
        public string _hmerominia_prosthikis_tropopoiis_ { get; set; }
        [DisplayName("Watchlist Member Type")]
        public int? _morfi_ { get; set; }
        [DisplayName("Kodikos Monados")]
        public int? _kodikos_monados_ { get; set; }
        [DisplayName("Syndesmos Sto Antistoixo Nomiko")]
        [StringLength(100)]
        public string _syndesmos_sto_antistoixo_nomiko__ { get; set; }
        [DisplayName("Discovery_date")]
        [Column(TypeName = "datetime")]
        public DateTime? discovery_date { get; set; }
        [DisplayName("Watchlist Person Number")]
        [StringLength(50)]
        public string _parapompi_ { get; set; }
        [DisplayName("Watchlist More Details")]
        [StringLength(100)]
        public string _sxolia1_ { get; set; }
        [DisplayName("Sxolia2")]
        [StringLength(100)]
        public string _sxolia2_ { get; set; }
        [DisplayName("Sxolia3")]
        [StringLength(100)]
        public string _sxolia3_ { get; set; }
        [DisplayName("Sanctions Program")]
        [StringLength(100)]
        public string sanctions_program { get; set; }
        [DisplayName("Eponumo Eponumia_")]
        [StringLength(100)]
        public string _eponumo_eponumia_ { get; set; }
        [DisplayName("Mikro Onoma_")]
        [StringLength(100)]
        public string _mikro_onoma_ { get; set; }
        [DisplayName("Mesaio Onoma_")]
        [StringLength(100)]
        public string _mesaio_onoma_ { get; set; }
        [DisplayName("Oloklhro Onoma_")]
        [StringLength(100)]
        public string _oloklhro_onoma_ { get; set; }
        [DisplayName("Fylo")]
        [StringLength(100)]
        public string _fylo_ { get; set; }
        [DisplayName("Details")]
        [StringLength(100)]
        public string details { get; set; }
        [DisplayName("Epaggelma Titlos_")]
        [StringLength(100)]
        public string _epaggelma_titlos_ { get; set; }
        [DisplayName("Glwssa")]
        [StringLength(100)]
        public string _glwssa_ { get; set; }
        [DisplayName("Dieuthinsi1")]
        [StringLength(100)]
        public string dieuthinsi1 { get; set; }
        [DisplayName("Dieuthinsi2")]
        [StringLength(100)]
        public string dieuthinsi2 { get; set; }
        [DisplayName("Dieuthinsi3")]
        [StringLength(100)]
        public string dieuthinsi3 { get; set; }
        [DisplayName("Odos")]
        [StringLength(100)]
        public string _odos_ { get; set; }
        [DisplayName("Arithmos Dieuthinsis")]
        [StringLength(100)]
        public string _arithmos_dieuthinsis_ { get; set; }
        [DisplayName("Tax Id")]
        [StringLength(100)]
        public string tax_id { get; set; }
        [DisplayName("City")]
        [StringLength(100)]
        public string city { get; set; }
        [DisplayName("Country")]
        [StringLength(100)]
        public string country { get; set; }
        [DisplayName("Afm")]
        [StringLength(100)]
        public string _afm_ { get; set; }
        [DisplayName("Kodikos1")]
        [StringLength(100)]
        public string _kodikos1_ { get; set; }
        [DisplayName("Kodikos2")]
        [StringLength(100)]
        public string _kodikos2_ { get; set; }
        [DisplayName("Kodikos3")]
        [StringLength(100)]
        public string _kodikos3_ { get; set; }
        [DisplayName("Kodikos4")]
        [StringLength(100)]
        public string _kodikos4_ { get; set; }
        [DisplayName("Arithmos Diavatiriou")]
        [StringLength(100)]
        public string _arithmos_diavatiriou_ { get; set; }
        [DisplayName("Xora Ekdosis Diavatiriou")]
        [StringLength(100)]
        public string _xora_ekdosis_diavatiriou_ { get; set; }
        [DisplayName("Alternate Country")]
        [StringLength(100)]
        public string _yphkoothta_ { get; set; }
        [DisplayName("Date of Birth")]
        [Column(TypeName = "datetime")]
        public DateTime? date_birth { get; set; }
        [DisplayName("Xora Gennhshs")]
        [StringLength(50)]
        public string _xora_gennhshs_ { get; set; }
        [DisplayName("Topothesia Gennhshs")]
        [StringLength(100)]
        public string _topothesia_gennhshs_ { get; set; }
        [DisplayName("Arithmos Nhologiou")]
        [StringLength(100)]
        public string _arithmos_nhologiou_ { get; set; }
        [DisplayName("Typos Ploiou")]
        [StringLength(100)]
        public string _typos_ploiou_ { get; set; }
        [DisplayName("Xorhtikothta")]
        [StringLength(100)]
        public string _xorhtikothta_ { get; set; }
        [DisplayName("Kataxorhmenh Xorhtikothta")]
        [StringLength(100)]
        public string _kataxorhmenh_xorhtikothta_ { get; set; }
        [DisplayName("Shmaia")]
        [StringLength(100)]
        public string _shmaia_ { get; set; }
        [DisplayName("Ploiokthths")]
        [StringLength(100)]
        public string _ploiokthths_ { get; set; }
        [DisplayName("Possible Location")]
        [StringLength(100)]
        public string _ethnikothta_ { get; set; }
        [DisplayName("Watchlist Org")]
        [StringLength(100)]
        public string watchlist_org { get; set; }
        [DisplayName("Position")]
        [StringLength(100)]
        public string _position_ { get; set; }
        [DisplayName("Length")]
        [StringLength(100)]
        public string _length_ { get; set; }
        [DisplayName("Identity Type 1")]
        [StringLength(100)]
        public string identity_type_1 { get; set; }
        [DisplayName("Identity Type 2")]
        [StringLength(100)]
        public string identity_type_2 { get; set; }
        [DisplayName("Identity Country 1")]
        [StringLength(100)]
        public string identity_country_1 { get; set; }
        [DisplayName("Identity Country 2")]
        [StringLength(100)]
        public string identity_country_2 { get; set; }
        [DisplayName("Birth Country")]
        [StringLength(100)]
        public string birth_country { get; set; }
        [DisplayName("Place Of Birth")]
        [StringLength(100)]
        public string place_of_birth { get; set; }
    }
}

