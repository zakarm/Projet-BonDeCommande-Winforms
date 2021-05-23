
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/23/2021 14:44:45
-- Generated from EDMX file: C:\Users\lenovo\Desktop\Projet Onssa\Projet Onssa\OnssaModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Onssa_Projet];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PVJFournisseur_PVJ]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PVJFournisseur] DROP CONSTRAINT [FK_PVJFournisseur_PVJ];
GO
IF OBJECT_ID(N'[dbo].[FK_PVJFournisseur_Fournisseur]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PVJFournisseur] DROP CONSTRAINT [FK_PVJFournisseur_Fournisseur];
GO
IF OBJECT_ID(N'[dbo].[FK_ModeleDevisFournisseur]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ModeleDevisSet] DROP CONSTRAINT [FK_ModeleDevisFournisseur];
GO
IF OBJECT_ID(N'[dbo].[FK_PVJCommission_PVJ]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PVJCommission] DROP CONSTRAINT [FK_PVJCommission_PVJ];
GO
IF OBJECT_ID(N'[dbo].[FK_PVJCommission_Commission]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PVJCommission] DROP CONSTRAINT [FK_PVJCommission_Commission];
GO
IF OBJECT_ID(N'[dbo].[FK_PVJConsultation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PVJSet] DROP CONSTRAINT [FK_PVJConsultation];
GO
IF OBJECT_ID(N'[dbo].[FK_ModeleDevisProduit_ModeleDevis]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ModeleDevisProduit] DROP CONSTRAINT [FK_ModeleDevisProduit_ModeleDevis];
GO
IF OBJECT_ID(N'[dbo].[FK_ModeleDevisProduit_Produit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ModeleDevisProduit] DROP CONSTRAINT [FK_ModeleDevisProduit_Produit];
GO
IF OBJECT_ID(N'[dbo].[FK_ConsultationFournisseur_Consultation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConsultationFournisseur] DROP CONSTRAINT [FK_ConsultationFournisseur_Consultation];
GO
IF OBJECT_ID(N'[dbo].[FK_ConsultationFournisseur_Fournisseur]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConsultationFournisseur] DROP CONSTRAINT [FK_ConsultationFournisseur_Fournisseur];
GO
IF OBJECT_ID(N'[dbo].[FK_CommissionPVR_Commission]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CommissionPVR] DROP CONSTRAINT [FK_CommissionPVR_Commission];
GO
IF OBJECT_ID(N'[dbo].[FK_CommissionPVR_PVR]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CommissionPVR] DROP CONSTRAINT [FK_CommissionPVR_PVR];
GO
IF OBJECT_ID(N'[dbo].[FK_OIPVR]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PVRSet] DROP CONSTRAINT [FK_OIPVR];
GO
IF OBJECT_ID(N'[dbo].[FK_FEOI]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OISet] DROP CONSTRAINT [FK_FEOI];
GO
IF OBJECT_ID(N'[dbo].[FK_OIOP]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OPSet] DROP CONSTRAINT [FK_OIOP];
GO
IF OBJECT_ID(N'[dbo].[FK_BCFE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FESet] DROP CONSTRAINT [FK_BCFE];
GO
IF OBJECT_ID(N'[dbo].[FK_BCMorasse]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BCSet] DROP CONSTRAINT [FK_BCMorasse];
GO
IF OBJECT_ID(N'[dbo].[FK_OVOP]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OVSet] DROP CONSTRAINT [FK_OVOP];
GO
IF OBJECT_ID(N'[dbo].[FK_PVJBC]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BCSet] DROP CONSTRAINT [FK_PVJBC];
GO
IF OBJECT_ID(N'[dbo].[FK_PVJFournisseur1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PVJSet] DROP CONSTRAINT [FK_PVJFournisseur1];
GO
IF OBJECT_ID(N'[dbo].[FK_ModeleDevisConsultation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ModeleDevisSet] DROP CONSTRAINT [FK_ModeleDevisConsultation];
GO
IF OBJECT_ID(N'[dbo].[FK_ParagrapheLrg]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LrgSet] DROP CONSTRAINT [FK_ParagrapheLrg];
GO
IF OBJECT_ID(N'[dbo].[FK_LigneLrg]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LigneSet] DROP CONSTRAINT [FK_LigneLrg];
GO
IF OBJECT_ID(N'[dbo].[FK_MorasseLigne]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MorasseSet] DROP CONSTRAINT [FK_MorasseLigne];
GO
IF OBJECT_ID(N'[dbo].[FK_LettreConsultationConsultation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LettreConsultationSet] DROP CONSTRAINT [FK_LettreConsultationConsultation];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FournisseurSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FournisseurSet];
GO
IF OBJECT_ID(N'[dbo].[CommissionSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CommissionSet];
GO
IF OBJECT_ID(N'[dbo].[ConsultationSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ConsultationSet];
GO
IF OBJECT_ID(N'[dbo].[PVJSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PVJSet];
GO
IF OBJECT_ID(N'[dbo].[ModeleDevisSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ModeleDevisSet];
GO
IF OBJECT_ID(N'[dbo].[ProduitSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProduitSet];
GO
IF OBJECT_ID(N'[dbo].[PVRSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PVRSet];
GO
IF OBJECT_ID(N'[dbo].[BCSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BCSet];
GO
IF OBJECT_ID(N'[dbo].[FESet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FESet];
GO
IF OBJECT_ID(N'[dbo].[MorasseSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MorasseSet];
GO
IF OBJECT_ID(N'[dbo].[OISet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OISet];
GO
IF OBJECT_ID(N'[dbo].[OPSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OPSet];
GO
IF OBJECT_ID(N'[dbo].[OVSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OVSet];
GO
IF OBJECT_ID(N'[dbo].[GestionCompteSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GestionCompteSet];
GO
IF OBJECT_ID(N'[dbo].[LigneSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LigneSet];
GO
IF OBJECT_ID(N'[dbo].[ParagrapheSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ParagrapheSet];
GO
IF OBJECT_ID(N'[dbo].[LrgSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LrgSet];
GO
IF OBJECT_ID(N'[dbo].[LettreConsultationSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LettreConsultationSet];
GO
IF OBJECT_ID(N'[dbo].[PVJFournisseur]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PVJFournisseur];
GO
IF OBJECT_ID(N'[dbo].[PVJCommission]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PVJCommission];
GO
IF OBJECT_ID(N'[dbo].[ModeleDevisProduit]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ModeleDevisProduit];
GO
IF OBJECT_ID(N'[dbo].[ConsultationFournisseur]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ConsultationFournisseur];
GO
IF OBJECT_ID(N'[dbo].[CommissionPVR]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CommissionPVR];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'FournisseurSet'
CREATE TABLE [dbo].[FournisseurSet] (
    [IdFournisseur] int IDENTITY(1,1) NOT NULL,
    [Nom] nvarchar(max)  NOT NULL,
    [Adresse] nvarchar(max)  NOT NULL,
    [RC_n] int  NOT NULL,
    [Patente_n] nvarchar(max)  NOT NULL,
    [IF_n] int  NOT NULL,
    [CNSS_n] int  NOT NULL,
    [Compte_bancaire_n] nvarchar(max)  NOT NULL,
    [ICE] nvarchar(max)  NOT NULL,
    [Ville] nvarchar(max)  NOT NULL,
    [Banque] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CommissionSet'
CREATE TABLE [dbo].[CommissionSet] (
    [IdCommission] int IDENTITY(1,1) NOT NULL,
    [Nom] nvarchar(max)  NOT NULL,
    [Prenom] nvarchar(max)  NOT NULL,
    [Fonction] nvarchar(max)  NOT NULL,
    [Affectation] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ConsultationSet'
CREATE TABLE [dbo].[ConsultationSet] (
    [IdConsultation] int IDENTITY(1,1) NOT NULL,
    [ObjetConsultation] nvarchar(max)  NOT NULL,
    [NumConsultation] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PVJSet'
CREATE TABLE [dbo].[PVJSet] (
    [IdPVJ] int IDENTITY(1,1) NOT NULL,
    [DateString] nvarchar(max)  NOT NULL,
    [DatePvj] datetime  NOT NULL,
    [NumPvj] nvarchar(max)  NOT NULL,
    [InfoConsultation_IdConsultation] int  NOT NULL,
    [InfoFournisseur_IdFournisseur] int  NOT NULL
);
GO

-- Creating table 'ModeleDevisSet'
CREATE TABLE [dbo].[ModeleDevisSet] (
    [IdModeleDevis] int IDENTITY(1,1) NOT NULL,
    [NumDevis] nvarchar(max)  NOT NULL,
    [Date] datetime  NOT NULL,
    [Total] float  NOT NULL,
    [Tva] float  NOT NULL,
    [Ttc] float  NOT NULL,
    [InfoFournisseur_IdFournisseur] int  NOT NULL,
    [InfoConsultation_IdConsultation] int  NOT NULL
);
GO

-- Creating table 'ProduitSet'
CREATE TABLE [dbo].[ProduitSet] (
    [IdProduit] int IDENTITY(1,1) NOT NULL,
    [Designation] nvarchar(max)  NOT NULL,
    [Unite] nvarchar(max)  NOT NULL,
    [Quantite] int  NOT NULL,
    [Prix_Unitaire] float  NOT NULL,
    [Prix_Total] float  NOT NULL
);
GO

-- Creating table 'PVRSet'
CREATE TABLE [dbo].[PVRSet] (
    [IdPVR] int IDENTITY(1,1) NOT NULL,
    [DateString] nvarchar(max)  NOT NULL,
    [DatePVR] datetime  NOT NULL,
    [NumPvr] nvarchar(max)  NOT NULL,
    [InfoOI_IdOI] int  NOT NULL
);
GO

-- Creating table 'BCSet'
CREATE TABLE [dbo].[BCSet] (
    [IdBC] int IDENTITY(1,1) NOT NULL,
    [NumBc] nvarchar(max)  NOT NULL,
    [Destination] nvarchar(max)  NOT NULL,
    [DelaiExecution] nvarchar(max)  NOT NULL,
    [DateBC] datetime  NOT NULL,
    [InfoMorasse_CodeMorasse] int  NOT NULL,
    [InfoPVJ_IdPVJ] int  NOT NULL
);
GO

-- Creating table 'FESet'
CREATE TABLE [dbo].[FESet] (
    [IdFE] int IDENTITY(1,1) NOT NULL,
    [CreditsBudgetaires] int  NOT NULL,
    [DepensesEngagees] int  NOT NULL,
    [Disponible] int  NOT NULL,
    [EngagementDepensesPropose] int  NOT NULL,
    [NumFe] nvarchar(max)  NOT NULL,
    [InfoBC_IdBC] int  NOT NULL
);
GO

-- Creating table 'MorasseSet'
CREATE TABLE [dbo].[MorasseSet] (
    [CodeMorasse] int  NOT NULL,
    [Exercice] nvarchar(max)  NOT NULL,
    [Budget] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Ligne_CodeLigne] int  NOT NULL
);
GO

-- Creating table 'OISet'
CREATE TABLE [dbo].[OISet] (
    [IdOI] int IDENTITY(1,1) NOT NULL,
    [NumOi] nvarchar(max)  NOT NULL,
    [DateOI] datetime  NOT NULL,
    [NumCompteDebit] nvarchar(max)  NOT NULL,
    [VisaControle] nvarchar(max)  NOT NULL,
    [VisaCsrs] nvarchar(max)  NOT NULL,
    [DatePaiement] datetime  NOT NULL,
    [VisaSordonnateur] nvarchar(max)  NOT NULL,
    [VisaTresorierPayeur] nvarchar(max)  NOT NULL,
    [InfoFE_IdFE] int  NOT NULL
);
GO

-- Creating table 'OPSet'
CREATE TABLE [dbo].[OPSet] (
    [IdOP] int IDENTITY(1,1) NOT NULL,
    [NumOP] nvarchar(max)  NOT NULL,
    [DateOP] datetime  NOT NULL,
    [InfoOI_IdOI] int  NOT NULL
);
GO

-- Creating table 'OVSet'
CREATE TABLE [dbo].[OVSet] (
    [IdOV] int IDENTITY(1,1) NOT NULL,
    [NumOV] nvarchar(max)  NOT NULL,
    [SousOrdonnateur] nvarchar(max)  NOT NULL,
    [TresorierPayeur] nvarchar(max)  NOT NULL,
    [InfoOP_IdOP] int  NOT NULL
);
GO

-- Creating table 'GestionCompteSet'
CREATE TABLE [dbo].[GestionCompteSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nom] nvarchar(max)  NOT NULL,
    [MotDePasse] nvarchar(max)  NOT NULL,
    [TypeCompte] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'LigneSet'
CREATE TABLE [dbo].[LigneSet] (
    [CodeLigne] int  NOT NULL,
    [DescriptionLigne] nvarchar(max)  NOT NULL,
    [InfoLrg_CodeLrg] int  NULL
);
GO

-- Creating table 'ParagrapheSet'
CREATE TABLE [dbo].[ParagrapheSet] (
    [NumPar] int  NOT NULL,
    [DescriptionPar] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'LrgSet'
CREATE TABLE [dbo].[LrgSet] (
    [CodeLrg] int  NOT NULL,
    [DescriptionLrg] nvarchar(max)  NOT NULL,
    [NumLrg] nvarchar(max)  NOT NULL,
    [InfoParagraphe_NumPar] int  NULL
);
GO

-- Creating table 'LettreConsultationSet'
CREATE TABLE [dbo].[LettreConsultationSet] (
    [IdLettre] int  NOT NULL,
    [DateLettre] datetime  NOT NULL,
    [Consultation_IdConsultation] int  NULL
);
GO

-- Creating table 'PVJFournisseur'
CREATE TABLE [dbo].[PVJFournisseur] (
    [ListPVJ1_IdPVJ] int  NOT NULL,
    [ListFournisseursRepondu_IdFournisseur] int  NOT NULL
);
GO

-- Creating table 'PVJCommission'
CREATE TABLE [dbo].[PVJCommission] (
    [ListPVJ_IdPVJ] int  NOT NULL,
    [ListCommissions_IdCommission] int  NOT NULL
);
GO

-- Creating table 'ModeleDevisProduit'
CREATE TABLE [dbo].[ModeleDevisProduit] (
    [ListModeleDevis_IdModeleDevis] int  NOT NULL,
    [ListProduit_IdProduit] int  NOT NULL
);
GO

-- Creating table 'ConsultationFournisseur'
CREATE TABLE [dbo].[ConsultationFournisseur] (
    [ListConsultation_IdConsultation] int  NOT NULL,
    [ListFournisseur_IdFournisseur] int  NOT NULL
);
GO

-- Creating table 'CommissionPVR'
CREATE TABLE [dbo].[CommissionPVR] (
    [ListCommission_IdCommission] int  NOT NULL,
    [ListPVR_IdPVR] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdFournisseur] in table 'FournisseurSet'
ALTER TABLE [dbo].[FournisseurSet]
ADD CONSTRAINT [PK_FournisseurSet]
    PRIMARY KEY CLUSTERED ([IdFournisseur] ASC);
GO

-- Creating primary key on [IdCommission] in table 'CommissionSet'
ALTER TABLE [dbo].[CommissionSet]
ADD CONSTRAINT [PK_CommissionSet]
    PRIMARY KEY CLUSTERED ([IdCommission] ASC);
GO

-- Creating primary key on [IdConsultation] in table 'ConsultationSet'
ALTER TABLE [dbo].[ConsultationSet]
ADD CONSTRAINT [PK_ConsultationSet]
    PRIMARY KEY CLUSTERED ([IdConsultation] ASC);
GO

-- Creating primary key on [IdPVJ] in table 'PVJSet'
ALTER TABLE [dbo].[PVJSet]
ADD CONSTRAINT [PK_PVJSet]
    PRIMARY KEY CLUSTERED ([IdPVJ] ASC);
GO

-- Creating primary key on [IdModeleDevis] in table 'ModeleDevisSet'
ALTER TABLE [dbo].[ModeleDevisSet]
ADD CONSTRAINT [PK_ModeleDevisSet]
    PRIMARY KEY CLUSTERED ([IdModeleDevis] ASC);
GO

-- Creating primary key on [IdProduit] in table 'ProduitSet'
ALTER TABLE [dbo].[ProduitSet]
ADD CONSTRAINT [PK_ProduitSet]
    PRIMARY KEY CLUSTERED ([IdProduit] ASC);
GO

-- Creating primary key on [IdPVR] in table 'PVRSet'
ALTER TABLE [dbo].[PVRSet]
ADD CONSTRAINT [PK_PVRSet]
    PRIMARY KEY CLUSTERED ([IdPVR] ASC);
GO

-- Creating primary key on [IdBC] in table 'BCSet'
ALTER TABLE [dbo].[BCSet]
ADD CONSTRAINT [PK_BCSet]
    PRIMARY KEY CLUSTERED ([IdBC] ASC);
GO

-- Creating primary key on [IdFE] in table 'FESet'
ALTER TABLE [dbo].[FESet]
ADD CONSTRAINT [PK_FESet]
    PRIMARY KEY CLUSTERED ([IdFE] ASC);
GO

-- Creating primary key on [CodeMorasse] in table 'MorasseSet'
ALTER TABLE [dbo].[MorasseSet]
ADD CONSTRAINT [PK_MorasseSet]
    PRIMARY KEY CLUSTERED ([CodeMorasse] ASC);
GO

-- Creating primary key on [IdOI] in table 'OISet'
ALTER TABLE [dbo].[OISet]
ADD CONSTRAINT [PK_OISet]
    PRIMARY KEY CLUSTERED ([IdOI] ASC);
GO

-- Creating primary key on [IdOP] in table 'OPSet'
ALTER TABLE [dbo].[OPSet]
ADD CONSTRAINT [PK_OPSet]
    PRIMARY KEY CLUSTERED ([IdOP] ASC);
GO

-- Creating primary key on [IdOV] in table 'OVSet'
ALTER TABLE [dbo].[OVSet]
ADD CONSTRAINT [PK_OVSet]
    PRIMARY KEY CLUSTERED ([IdOV] ASC);
GO

-- Creating primary key on [Id] in table 'GestionCompteSet'
ALTER TABLE [dbo].[GestionCompteSet]
ADD CONSTRAINT [PK_GestionCompteSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [CodeLigne] in table 'LigneSet'
ALTER TABLE [dbo].[LigneSet]
ADD CONSTRAINT [PK_LigneSet]
    PRIMARY KEY CLUSTERED ([CodeLigne] ASC);
GO

-- Creating primary key on [NumPar] in table 'ParagrapheSet'
ALTER TABLE [dbo].[ParagrapheSet]
ADD CONSTRAINT [PK_ParagrapheSet]
    PRIMARY KEY CLUSTERED ([NumPar] ASC);
GO

-- Creating primary key on [CodeLrg] in table 'LrgSet'
ALTER TABLE [dbo].[LrgSet]
ADD CONSTRAINT [PK_LrgSet]
    PRIMARY KEY CLUSTERED ([CodeLrg] ASC);
GO

-- Creating primary key on [IdLettre] in table 'LettreConsultationSet'
ALTER TABLE [dbo].[LettreConsultationSet]
ADD CONSTRAINT [PK_LettreConsultationSet]
    PRIMARY KEY CLUSTERED ([IdLettre] ASC);
GO

-- Creating primary key on [ListPVJ1_IdPVJ], [ListFournisseursRepondu_IdFournisseur] in table 'PVJFournisseur'
ALTER TABLE [dbo].[PVJFournisseur]
ADD CONSTRAINT [PK_PVJFournisseur]
    PRIMARY KEY CLUSTERED ([ListPVJ1_IdPVJ], [ListFournisseursRepondu_IdFournisseur] ASC);
GO

-- Creating primary key on [ListPVJ_IdPVJ], [ListCommissions_IdCommission] in table 'PVJCommission'
ALTER TABLE [dbo].[PVJCommission]
ADD CONSTRAINT [PK_PVJCommission]
    PRIMARY KEY CLUSTERED ([ListPVJ_IdPVJ], [ListCommissions_IdCommission] ASC);
GO

-- Creating primary key on [ListModeleDevis_IdModeleDevis], [ListProduit_IdProduit] in table 'ModeleDevisProduit'
ALTER TABLE [dbo].[ModeleDevisProduit]
ADD CONSTRAINT [PK_ModeleDevisProduit]
    PRIMARY KEY CLUSTERED ([ListModeleDevis_IdModeleDevis], [ListProduit_IdProduit] ASC);
GO

-- Creating primary key on [ListConsultation_IdConsultation], [ListFournisseur_IdFournisseur] in table 'ConsultationFournisseur'
ALTER TABLE [dbo].[ConsultationFournisseur]
ADD CONSTRAINT [PK_ConsultationFournisseur]
    PRIMARY KEY CLUSTERED ([ListConsultation_IdConsultation], [ListFournisseur_IdFournisseur] ASC);
GO

-- Creating primary key on [ListCommission_IdCommission], [ListPVR_IdPVR] in table 'CommissionPVR'
ALTER TABLE [dbo].[CommissionPVR]
ADD CONSTRAINT [PK_CommissionPVR]
    PRIMARY KEY CLUSTERED ([ListCommission_IdCommission], [ListPVR_IdPVR] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ListPVJ1_IdPVJ] in table 'PVJFournisseur'
ALTER TABLE [dbo].[PVJFournisseur]
ADD CONSTRAINT [FK_PVJFournisseur_PVJ]
    FOREIGN KEY ([ListPVJ1_IdPVJ])
    REFERENCES [dbo].[PVJSet]
        ([IdPVJ])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ListFournisseursRepondu_IdFournisseur] in table 'PVJFournisseur'
ALTER TABLE [dbo].[PVJFournisseur]
ADD CONSTRAINT [FK_PVJFournisseur_Fournisseur]
    FOREIGN KEY ([ListFournisseursRepondu_IdFournisseur])
    REFERENCES [dbo].[FournisseurSet]
        ([IdFournisseur])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PVJFournisseur_Fournisseur'
CREATE INDEX [IX_FK_PVJFournisseur_Fournisseur]
ON [dbo].[PVJFournisseur]
    ([ListFournisseursRepondu_IdFournisseur]);
GO

-- Creating foreign key on [InfoFournisseur_IdFournisseur] in table 'ModeleDevisSet'
ALTER TABLE [dbo].[ModeleDevisSet]
ADD CONSTRAINT [FK_ModeleDevisFournisseur]
    FOREIGN KEY ([InfoFournisseur_IdFournisseur])
    REFERENCES [dbo].[FournisseurSet]
        ([IdFournisseur])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ModeleDevisFournisseur'
CREATE INDEX [IX_FK_ModeleDevisFournisseur]
ON [dbo].[ModeleDevisSet]
    ([InfoFournisseur_IdFournisseur]);
GO

-- Creating foreign key on [ListPVJ_IdPVJ] in table 'PVJCommission'
ALTER TABLE [dbo].[PVJCommission]
ADD CONSTRAINT [FK_PVJCommission_PVJ]
    FOREIGN KEY ([ListPVJ_IdPVJ])
    REFERENCES [dbo].[PVJSet]
        ([IdPVJ])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ListCommissions_IdCommission] in table 'PVJCommission'
ALTER TABLE [dbo].[PVJCommission]
ADD CONSTRAINT [FK_PVJCommission_Commission]
    FOREIGN KEY ([ListCommissions_IdCommission])
    REFERENCES [dbo].[CommissionSet]
        ([IdCommission])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PVJCommission_Commission'
CREATE INDEX [IX_FK_PVJCommission_Commission]
ON [dbo].[PVJCommission]
    ([ListCommissions_IdCommission]);
GO

-- Creating foreign key on [InfoConsultation_IdConsultation] in table 'PVJSet'
ALTER TABLE [dbo].[PVJSet]
ADD CONSTRAINT [FK_PVJConsultation]
    FOREIGN KEY ([InfoConsultation_IdConsultation])
    REFERENCES [dbo].[ConsultationSet]
        ([IdConsultation])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PVJConsultation'
CREATE INDEX [IX_FK_PVJConsultation]
ON [dbo].[PVJSet]
    ([InfoConsultation_IdConsultation]);
GO

-- Creating foreign key on [ListModeleDevis_IdModeleDevis] in table 'ModeleDevisProduit'
ALTER TABLE [dbo].[ModeleDevisProduit]
ADD CONSTRAINT [FK_ModeleDevisProduit_ModeleDevis]
    FOREIGN KEY ([ListModeleDevis_IdModeleDevis])
    REFERENCES [dbo].[ModeleDevisSet]
        ([IdModeleDevis])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ListProduit_IdProduit] in table 'ModeleDevisProduit'
ALTER TABLE [dbo].[ModeleDevisProduit]
ADD CONSTRAINT [FK_ModeleDevisProduit_Produit]
    FOREIGN KEY ([ListProduit_IdProduit])
    REFERENCES [dbo].[ProduitSet]
        ([IdProduit])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ModeleDevisProduit_Produit'
CREATE INDEX [IX_FK_ModeleDevisProduit_Produit]
ON [dbo].[ModeleDevisProduit]
    ([ListProduit_IdProduit]);
GO

-- Creating foreign key on [ListConsultation_IdConsultation] in table 'ConsultationFournisseur'
ALTER TABLE [dbo].[ConsultationFournisseur]
ADD CONSTRAINT [FK_ConsultationFournisseur_Consultation]
    FOREIGN KEY ([ListConsultation_IdConsultation])
    REFERENCES [dbo].[ConsultationSet]
        ([IdConsultation])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ListFournisseur_IdFournisseur] in table 'ConsultationFournisseur'
ALTER TABLE [dbo].[ConsultationFournisseur]
ADD CONSTRAINT [FK_ConsultationFournisseur_Fournisseur]
    FOREIGN KEY ([ListFournisseur_IdFournisseur])
    REFERENCES [dbo].[FournisseurSet]
        ([IdFournisseur])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ConsultationFournisseur_Fournisseur'
CREATE INDEX [IX_FK_ConsultationFournisseur_Fournisseur]
ON [dbo].[ConsultationFournisseur]
    ([ListFournisseur_IdFournisseur]);
GO

-- Creating foreign key on [ListCommission_IdCommission] in table 'CommissionPVR'
ALTER TABLE [dbo].[CommissionPVR]
ADD CONSTRAINT [FK_CommissionPVR_Commission]
    FOREIGN KEY ([ListCommission_IdCommission])
    REFERENCES [dbo].[CommissionSet]
        ([IdCommission])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ListPVR_IdPVR] in table 'CommissionPVR'
ALTER TABLE [dbo].[CommissionPVR]
ADD CONSTRAINT [FK_CommissionPVR_PVR]
    FOREIGN KEY ([ListPVR_IdPVR])
    REFERENCES [dbo].[PVRSet]
        ([IdPVR])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CommissionPVR_PVR'
CREATE INDEX [IX_FK_CommissionPVR_PVR]
ON [dbo].[CommissionPVR]
    ([ListPVR_IdPVR]);
GO

-- Creating foreign key on [InfoOI_IdOI] in table 'PVRSet'
ALTER TABLE [dbo].[PVRSet]
ADD CONSTRAINT [FK_OIPVR]
    FOREIGN KEY ([InfoOI_IdOI])
    REFERENCES [dbo].[OISet]
        ([IdOI])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OIPVR'
CREATE INDEX [IX_FK_OIPVR]
ON [dbo].[PVRSet]
    ([InfoOI_IdOI]);
GO

-- Creating foreign key on [InfoFE_IdFE] in table 'OISet'
ALTER TABLE [dbo].[OISet]
ADD CONSTRAINT [FK_FEOI]
    FOREIGN KEY ([InfoFE_IdFE])
    REFERENCES [dbo].[FESet]
        ([IdFE])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FEOI'
CREATE INDEX [IX_FK_FEOI]
ON [dbo].[OISet]
    ([InfoFE_IdFE]);
GO

-- Creating foreign key on [InfoOI_IdOI] in table 'OPSet'
ALTER TABLE [dbo].[OPSet]
ADD CONSTRAINT [FK_OIOP]
    FOREIGN KEY ([InfoOI_IdOI])
    REFERENCES [dbo].[OISet]
        ([IdOI])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OIOP'
CREATE INDEX [IX_FK_OIOP]
ON [dbo].[OPSet]
    ([InfoOI_IdOI]);
GO

-- Creating foreign key on [InfoBC_IdBC] in table 'FESet'
ALTER TABLE [dbo].[FESet]
ADD CONSTRAINT [FK_BCFE]
    FOREIGN KEY ([InfoBC_IdBC])
    REFERENCES [dbo].[BCSet]
        ([IdBC])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BCFE'
CREATE INDEX [IX_FK_BCFE]
ON [dbo].[FESet]
    ([InfoBC_IdBC]);
GO

-- Creating foreign key on [InfoMorasse_CodeMorasse] in table 'BCSet'
ALTER TABLE [dbo].[BCSet]
ADD CONSTRAINT [FK_BCMorasse]
    FOREIGN KEY ([InfoMorasse_CodeMorasse])
    REFERENCES [dbo].[MorasseSet]
        ([CodeMorasse])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BCMorasse'
CREATE INDEX [IX_FK_BCMorasse]
ON [dbo].[BCSet]
    ([InfoMorasse_CodeMorasse]);
GO

-- Creating foreign key on [InfoOP_IdOP] in table 'OVSet'
ALTER TABLE [dbo].[OVSet]
ADD CONSTRAINT [FK_OVOP]
    FOREIGN KEY ([InfoOP_IdOP])
    REFERENCES [dbo].[OPSet]
        ([IdOP])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OVOP'
CREATE INDEX [IX_FK_OVOP]
ON [dbo].[OVSet]
    ([InfoOP_IdOP]);
GO

-- Creating foreign key on [InfoPVJ_IdPVJ] in table 'BCSet'
ALTER TABLE [dbo].[BCSet]
ADD CONSTRAINT [FK_PVJBC]
    FOREIGN KEY ([InfoPVJ_IdPVJ])
    REFERENCES [dbo].[PVJSet]
        ([IdPVJ])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PVJBC'
CREATE INDEX [IX_FK_PVJBC]
ON [dbo].[BCSet]
    ([InfoPVJ_IdPVJ]);
GO

-- Creating foreign key on [InfoFournisseur_IdFournisseur] in table 'PVJSet'
ALTER TABLE [dbo].[PVJSet]
ADD CONSTRAINT [FK_PVJFournisseur1]
    FOREIGN KEY ([InfoFournisseur_IdFournisseur])
    REFERENCES [dbo].[FournisseurSet]
        ([IdFournisseur])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PVJFournisseur1'
CREATE INDEX [IX_FK_PVJFournisseur1]
ON [dbo].[PVJSet]
    ([InfoFournisseur_IdFournisseur]);
GO

-- Creating foreign key on [InfoConsultation_IdConsultation] in table 'ModeleDevisSet'
ALTER TABLE [dbo].[ModeleDevisSet]
ADD CONSTRAINT [FK_ModeleDevisConsultation]
    FOREIGN KEY ([InfoConsultation_IdConsultation])
    REFERENCES [dbo].[ConsultationSet]
        ([IdConsultation])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ModeleDevisConsultation'
CREATE INDEX [IX_FK_ModeleDevisConsultation]
ON [dbo].[ModeleDevisSet]
    ([InfoConsultation_IdConsultation]);
GO

-- Creating foreign key on [InfoParagraphe_NumPar] in table 'LrgSet'
ALTER TABLE [dbo].[LrgSet]
ADD CONSTRAINT [FK_ParagrapheLrg]
    FOREIGN KEY ([InfoParagraphe_NumPar])
    REFERENCES [dbo].[ParagrapheSet]
        ([NumPar])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ParagrapheLrg'
CREATE INDEX [IX_FK_ParagrapheLrg]
ON [dbo].[LrgSet]
    ([InfoParagraphe_NumPar]);
GO

-- Creating foreign key on [InfoLrg_CodeLrg] in table 'LigneSet'
ALTER TABLE [dbo].[LigneSet]
ADD CONSTRAINT [FK_LigneLrg]
    FOREIGN KEY ([InfoLrg_CodeLrg])
    REFERENCES [dbo].[LrgSet]
        ([CodeLrg])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LigneLrg'
CREATE INDEX [IX_FK_LigneLrg]
ON [dbo].[LigneSet]
    ([InfoLrg_CodeLrg]);
GO

-- Creating foreign key on [Ligne_CodeLigne] in table 'MorasseSet'
ALTER TABLE [dbo].[MorasseSet]
ADD CONSTRAINT [FK_MorasseLigne]
    FOREIGN KEY ([Ligne_CodeLigne])
    REFERENCES [dbo].[LigneSet]
        ([CodeLigne])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MorasseLigne'
CREATE INDEX [IX_FK_MorasseLigne]
ON [dbo].[MorasseSet]
    ([Ligne_CodeLigne]);
GO

-- Creating foreign key on [Consultation_IdConsultation] in table 'LettreConsultationSet'
ALTER TABLE [dbo].[LettreConsultationSet]
ADD CONSTRAINT [FK_LettreConsultationConsultation]
    FOREIGN KEY ([Consultation_IdConsultation])
    REFERENCES [dbo].[ConsultationSet]
        ([IdConsultation])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LettreConsultationConsultation'
CREATE INDEX [IX_FK_LettreConsultationConsultation]
ON [dbo].[LettreConsultationSet]
    ([Consultation_IdConsultation]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------