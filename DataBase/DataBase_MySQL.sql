/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     24/04/2015 7:32:45 p. m.                     */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('animal') and o.name = 'fk_animal_relations_animal_g')
alter table animal
   drop constraint fk_animal_relations_animal_g
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('animal') and o.name = 'fk_animal_relations_tipo_ani')
alter table animal
   drop constraint fk_animal_relations_tipo_ani
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('animal') and o.name = 'fk_animal_relations_usuario')
alter table animal
   drop constraint fk_animal_relations_usuario
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('animal') and o.name = 'fk_animal_relations_estado')
alter table animal
   drop constraint fk_animal_relations_estado
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('entidad') and o.name = 'fk_entidad_relations_usuario')
alter table entidad
   drop constraint fk_entidad_relations_usuario
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('entidad') and o.name = 'fk_entidad_relations_tipo_ent')
alter table entidad
   drop constraint fk_entidad_relations_tipo_ent
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('raza') and o.name = 'fk_raza_relations_tipo_ani')
alter table raza
   drop constraint fk_raza_relations_tipo_ani
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('usuario') and o.name = 'fk_usuario_relations_genero')
alter table usuario
   drop constraint fk_usuario_relations_genero
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('animal')
            and   name  = 'relationship_10_fk'
            and   indid > 0
            and   indid < 255)
   drop index animal.relationship_10_fk
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('animal')
            and   name  = 'relationship_8_fk'
            and   indid > 0
            and   indid < 255)
   drop index animal.relationship_8_fk
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('animal')
            and   name  = 'relationship_7_fk'
            and   indid > 0
            and   indid < 255)
   drop index animal.relationship_7_fk
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('animal')
            and   name  = 'relationship_6_fk'
            and   indid > 0
            and   indid < 255)
   drop index animal.relationship_6_fk
go

if exists (select 1
            from  sysobjects
           where  id = object_id('animal')
            and   type = 'U')
   drop table animal
go

if exists (select 1
            from  sysobjects
           where  id = object_id('animal_genero')
            and   type = 'U')
   drop table animal_genero
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('entidad')
            and   name  = 'relationship_11_fk'
            and   indid > 0
            and   indid < 255)
   drop index entidad.relationship_11_fk
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('entidad')
            and   name  = 'relationship_4_fk'
            and   indid > 0
            and   indid < 255)
   drop index entidad.relationship_4_fk
go

if exists (select 1
            from  sysobjects
           where  id = object_id('entidad')
            and   type = 'U')
   drop table entidad
go

if exists (select 1
            from  sysobjects
           where  id = object_id('estado')
            and   type = 'U')
   drop table estado
go

if exists (select 1
            from  sysobjects
           where  id = object_id('genero')
            and   type = 'U')
   drop table genero
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('raza')
            and   name  = 'relationship_5_fk'
            and   indid > 0
            and   indid < 255)
   drop index raza.relationship_5_fk
go

if exists (select 1
            from  sysobjects
           where  id = object_id('raza')
            and   type = 'U')
   drop table raza
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tipo_animal')
            and   type = 'U')
   drop table tipo_animal
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tipo_entidad')
            and   type = 'U')
   drop table tipo_entidad
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('usuario')
            and   name  = 'relationship_9_fk'
            and   indid > 0
            and   indid < 255)
   drop index usuario.relationship_9_fk
go

if exists (select 1
            from  sysobjects
           where  id = object_id('usuario')
            and   type = 'U')
   drop table usuario
go

/*==============================================================*/
/* Table: animal                                                */
/*==============================================================*/
create table animal (
   id_animal            numeric              identity,
   id_tipo_animal       int                  not null,
   id_usuario           varchar(80)          not null,
   id_estado            int                  not null,
   id_animal_genero     int                  not null,
   ani_nombre           varchar(50)          null,
   ani_edad             int                  null,
   ani_tamano           int                  null,
   constraint pk_animal primary key nonclustered (id_animal)
)
go

/*==============================================================*/
/* Index: relationship_6_fk                                     */
/*==============================================================*/
create index relationship_6_fk on animal (
id_tipo_animal asc
)
go

/*==============================================================*/
/* Index: relationship_7_fk                                     */
/*==============================================================*/
create index relationship_7_fk on animal (
id_usuario asc
)
go

/*==============================================================*/
/* Index: relationship_8_fk                                     */
/*==============================================================*/
create index relationship_8_fk on animal (
id_estado asc
)
go

/*==============================================================*/
/* Index: relationship_10_fk                                    */
/*==============================================================*/
create index relationship_10_fk on animal (
id_animal_genero asc
)
go

/*==============================================================*/
/* Table: animal_genero                                         */
/*==============================================================*/
create table animal_genero (
   id_animal_genero     numeric              identity,
   animal_genero        varchar(20)          not null,
   constraint pk_animal_genero primary key nonclustered (id_animal_genero)
)
go

/*==============================================================*/
/* Table: entidad                                               */
/*==============================================================*/
create table entidad (
   id_entidad           numeric              identity,
   id_tipo_entidad      int                  not null,
   id_usuario           varchar(80)          not null,
   ent_nombre           varchar(150)         not null,
   ent_ubicacion        varchar(200)         not null,
   ent_telefono         varchar(20)          not null,
   ent_facebook         varchar(200)         null,
   ent_twitter          varchar(200)         null,
   constraint pk_entidad primary key nonclustered (id_entidad)
)
go

/*==============================================================*/
/* Index: relationship_4_fk                                     */
/*==============================================================*/
create index relationship_4_fk on entidad (
id_tipo_entidad asc
)
go

/*==============================================================*/
/* Index: relationship_11_fk                                    */
/*==============================================================*/
create index relationship_11_fk on entidad (
id_usuario asc
)
go

/*==============================================================*/
/* Table: estado                                                */
/*==============================================================*/
create table estado (
   id_estado            numeric              identity,
   estado               varchar(50)          not null,
   constraint pk_estado primary key nonclustered (id_estado)
)
go

/*==============================================================*/
/* Table: genero                                                */
/*==============================================================*/
create table genero (
   id_genero            numeric              identity,
   genero               varchar(20)          null,
   constraint pk_genero primary key nonclustered (id_genero)
)
go

/*==============================================================*/
/* Table: raza                                                  */
/*==============================================================*/
create table raza (
   id_raza              numeric              identity,
   id_tipo_animal       int                  not null,
   raza                 varchar(150)         not null,
   constraint pk_raza primary key nonclustered (id_raza)
)
go

/*==============================================================*/
/* Index: relationship_5_fk                                     */
/*==============================================================*/
create index relationship_5_fk on raza (
id_tipo_animal asc
)
go

/*==============================================================*/
/* Table: tipo_animal                                           */
/*==============================================================*/
create table tipo_animal (
   id_tipo_animal       numeric              identity,
   tipo_animal          varchar(100)         not null,
   constraint pk_tipo_animal primary key nonclustered (id_tipo_animal)
)
go

/*==============================================================*/
/* Table: tipo_entidad                                          */
/*==============================================================*/
create table tipo_entidad (
   id_tipo_entidad      numeric              identity,
   tipo_usuario         varchar(100)         not null,
   constraint pk_tipo_entidad primary key nonclustered (id_tipo_entidad)
)
go

/*==============================================================*/
/* Table: usuario                                               */
/*==============================================================*/
create table usuario (
   id_usuario           varchar(80)          not null,
   id_genero            int                  not null,
   usu_contrasena       varchar(50)          not null,
   usu_nombre           varchar(50)          not null,
   usu_apellido         varchar(50)          not null,
   usu_fecha_nacimiento datetime             not null,
   usu_telefono         varchar(20)          not null,
   usu_ubicacion        varchar(200)         null,
   usu_facebook         varchar(200)         null,
   usu_twitter          varchar(200)         null,
   constraint pk_usuario primary key nonclustered (id_usuario)
)
go

/*==============================================================*/
/* Index: relationship_9_fk                                     */
/*==============================================================*/
create index relationship_9_fk on usuario (
id_genero asc
)
go

alter table animal
   add constraint fk_animal_relations_animal_g foreign key (id_animal_genero)
      references animal_genero (id_animal_genero)
go

alter table animal
   add constraint fk_animal_relations_tipo_ani foreign key (id_tipo_animal)
      references tipo_animal (id_tipo_animal)
go

alter table animal
   add constraint fk_animal_relations_usuario foreign key (id_usuario)
      references usuario (id_usuario)
go

alter table animal
   add constraint fk_animal_relations_estado foreign key (id_estado)
      references estado (id_estado)
go

alter table entidad
   add constraint fk_entidad_relations_usuario foreign key (id_usuario)
      references usuario (id_usuario)
go

alter table entidad
   add constraint fk_entidad_relations_tipo_ent foreign key (id_tipo_entidad)
      references tipo_entidad (id_tipo_entidad)
go

alter table raza
   add constraint fk_raza_relations_tipo_ani foreign key (id_tipo_animal)
      references tipo_animal (id_tipo_animal)
go

alter table usuario
   add constraint fk_usuario_relations_genero foreign key (id_genero)
      references genero (id_genero)
go

