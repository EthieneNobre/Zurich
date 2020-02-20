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

Date: 2020-02-11 00:39:36
*/


-- ----------------------------
-- Table structure for tb_Relacao
-- ----------------------------
DROP TABLE [dbo].[tb_Relacao]
GO
CREATE TABLE [dbo].[tb_Relacao] (
[idRelacao] int NOT NULL IDENTITY(1,1) ,
[idSegurado] int NULL ,
[idVeiculo] int NULL ,
[Ativo] int NULL 
)


GO

-- ----------------------------
-- Indexes structure for table tb_Relacao
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table tb_Relacao
-- ----------------------------
ALTER TABLE [dbo].[tb_Relacao] ADD PRIMARY KEY ([idRelacao])
GO
