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

Date: 2020-02-11 00:40:08
*/


-- ----------------------------
-- Table structure for tb_Veiculo
-- ----------------------------
DROP TABLE [dbo].[tb_Veiculo]
GO
CREATE TABLE [dbo].[tb_Veiculo] (
[IdVeiculo] int NOT NULL IDENTITY(1,1) ,
[Segurado] int NULL ,
[ValorVeiculo] decimal(18,2) NULL ,
[Marca] varchar(50) NULL ,
[Modelo] varchar(255) NULL ,
[Ativo] int NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[tb_Veiculo]', RESEED, 3)
GO

-- ----------------------------
-- Indexes structure for table tb_Veiculo
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table tb_Veiculo
-- ----------------------------
ALTER TABLE [dbo].[tb_Veiculo] ADD PRIMARY KEY ([IdVeiculo])
GO
