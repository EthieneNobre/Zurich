/*
Navicat SQL Server Data Transfer

Source Server         : Zurich
Source Server Version : 140000
Source Host           : DESKTOP-8U494T3\SQLEXPRESS:1433
Source Database       : db_Zurich
Source Schema         : dbo

Target Server Type    : SQL Server
Target Server Version : 140000
File Encoding         : 65001

Date: 2020-02-11 00:39:59
*/


-- ----------------------------
-- Table structure for tb_Seguro
-- ----------------------------
DROP TABLE [dbo].[tb_Seguro]
GO
CREATE TABLE [dbo].[tb_Seguro] (
[idSeguro] int NOT NULL IDENTITY(1,1) ,
[SeguradoId] int NULL ,
[ValorVeiculo] decimal(18,2) NULL ,
[PremioRisco] decimal(18,2) NULL ,
[PremioPuro] decimal(18,2) NULL ,
[PremioComercial] decimal(18,2) NULL ,
[TaxaRisco] decimal(18,2) NULL ,
[ValorSeguro] decimal(18,2) NULL ,
[Ativo] int NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[tb_Seguro]', RESEED, 5)
GO

-- ----------------------------
-- Indexes structure for table tb_Seguro
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table tb_Seguro
-- ----------------------------
ALTER TABLE [dbo].[tb_Seguro] ADD PRIMARY KEY ([idSeguro])
GO
