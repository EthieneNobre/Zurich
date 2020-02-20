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

Date: 2020-02-11 00:39:48
*/


-- ----------------------------
-- Table structure for tb_Segurado
-- ----------------------------
DROP TABLE [dbo].[tb_Segurado]
GO
CREATE TABLE [dbo].[tb_Segurado] (
[idSegurado] int NOT NULL IDENTITY(1,1) ,
[Nome] varchar(255) NULL ,
[CPF] varchar(20) NULL ,
[Idade] int NULL ,
[Ativo] int NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[tb_Segurado]', RESEED, 3)
GO

-- ----------------------------
-- Indexes structure for table tb_Segurado
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table tb_Segurado
-- ----------------------------
ALTER TABLE [dbo].[tb_Segurado] ADD PRIMARY KEY ([idSegurado])
GO
