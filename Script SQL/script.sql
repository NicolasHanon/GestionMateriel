--Table

USE [nicolashanon]
GO

/****** Object:  Table [dbo].[LP_Combinaison]    Script Date: 08/06/2023 21:59:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[LP_Combinaison](
	[ID] [int] NOT NULL,
	[Taille] [varchar](5) NULL,
	[saisonCombi] [varchar](10) NULL,
 CONSTRAINT [PK__LP_Combi__3214EC27DDD3461D] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[LP_Combinaison]  WITH CHECK ADD  CONSTRAINT [FK__LP_Combinais__ID__336AA144] FOREIGN KEY([ID])
REFERENCES [dbo].[LP_Matériel] ([ID])
GO

ALTER TABLE [dbo].[LP_Combinaison] CHECK CONSTRAINT [FK__LP_Combinais__ID__336AA144]
GO

USE [nicolashanon]
GO

/****** Object:  Table [dbo].[LP_Matériel]    Script Date: 08/06/2023 21:59:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[LP_Matériel](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[marque] [varchar](50) NULL,
	[Nom] [varchar](50) NULL,
 CONSTRAINT [PK__LP_Matér__3214EC277E684AC5] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [nicolashanon]
GO

/****** Object:  Table [dbo].[LP_Monopalme]    Script Date: 08/06/2023 22:00:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[LP_Monopalme](
	[ID] [int] NOT NULL,
	[TypeMono] [varchar](50) NULL,
	[pointure] [varchar](5) NULL,
 CONSTRAINT [PK__LP_Monop__3214EC27015365E7] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[LP_Monopalme]  WITH CHECK ADD  CONSTRAINT [FK__LP_Monopalme__ID__39237A9A] FOREIGN KEY([ID])
REFERENCES [dbo].[LP_Matériel] ([ID])
GO

ALTER TABLE [dbo].[LP_Monopalme] CHECK CONSTRAINT [FK__LP_Monopalme__ID__39237A9A]
GO

USE [nicolashanon]
GO

/****** Object:  Table [dbo].[LP_Nageur]    Script Date: 08/06/2023 22:00:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[LP_Nageur](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [varchar](50) NULL,
	[Prénom] [varchar](50) NULL,
	[mail] [varchar](50) NULL,
	[telephone] [varchar](10) NULL,
	[Nom_chiffree] [varbinary](256) NULL,
	[Prénom_chiffree] [varbinary](256) NULL,
	[Mail_chiffree] [varbinary](256) NULL,
	[Telephone_chiffree] [varbinary](256) NULL,
 CONSTRAINT [PK__LP_Nageu__3214EC27D6999A5C] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [nicolashanon]
GO

/****** Object:  Table [dbo].[LP_Pret]    Script Date: 08/06/2023 22:00:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[LP_Pret](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[DateEmprunt] [date] NULL,
	[dateRetourPret] [date] NULL,
	[ID_1] [int] NOT NULL,
	[ID_2] [int] NOT NULL,
 CONSTRAINT [PK__LP_Pret__3213E83F93CD1F49] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[LP_Pret]  WITH CHECK ADD  CONSTRAINT [FK__LP_Pret__ID_1__2CBDA3B5] FOREIGN KEY([ID_1])
REFERENCES [dbo].[LP_Matériel] ([ID])
GO

ALTER TABLE [dbo].[LP_Pret] CHECK CONSTRAINT [FK__LP_Pret__ID_1__2CBDA3B5]
GO

ALTER TABLE [dbo].[LP_Pret]  WITH CHECK ADD  CONSTRAINT [FK__LP_Pret__ID_2__2DB1C7EE] FOREIGN KEY([ID_2])
REFERENCES [dbo].[LP_Nageur] ([ID])
GO

ALTER TABLE [dbo].[LP_Pret] CHECK CONSTRAINT [FK__LP_Pret__ID_2__2DB1C7EE]
GO

USE [nicolashanon]
GO

/****** Object:  View [dbo].[vLP_Nageur_Chiffree]    Script Date: 08/06/2023 22:00:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[vLP_Nageur_Chiffree]
AS
SELECT        ID, Nom_chiffree, Prénom_chiffree, Mail_chiffree, Telephone_chiffree
FROM            dbo.LP_Nageur
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "LP_Nageur"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 246
            End
            DisplayFlags = 280
            TopColumn = 5
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vLP_Nageur_Chiffree'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vLP_Nageur_Chiffree'
GO

USE [nicolashanon]
GO

/****** Object:  View [dbo].[vLP_Nageur_Chiffree]    Script Date: 08/06/2023 22:00:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[vLP_Nageur_Chiffree]
AS
SELECT        ID, Nom_chiffree, Prénom_chiffree, Mail_chiffree, Telephone_chiffree
FROM            dbo.LP_Nageur
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "LP_Nageur"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 246
            End
            DisplayFlags = 280
            TopColumn = 5
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vLP_Nageur_Chiffree'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vLP_Nageur_Chiffree'
GO

USE [nicolashanon]
GO

/****** Object:  View [dbo].[vLP_VoirMonopalme]    Script Date: 08/06/2023 22:01:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[vLP_VoirMonopalme]
AS
SELECT        M.ID, M.marque, M.Nom, Mo.TypeMono, Mo.pointure
FROM            dbo.LP_Matériel AS M INNER JOIN
                         dbo.LP_Monopalme AS Mo ON Mo.ID = M.ID
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "M"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 119
               Right = 246
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mo"
            Begin Extent = 
               Top = 6
               Left = 284
               Bottom = 119
               Right = 492
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vLP_VoirMonopalme'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vLP_VoirMonopalme'
GO

USE [nicolashanon]
GO

/****** Object:  View [dbo].[vLP_VoirMonopalme]    Script Date: 08/06/2023 22:01:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[vLP_VoirMonopalme]
AS
SELECT        M.ID, M.marque, M.Nom, Mo.TypeMono, Mo.pointure
FROM            dbo.LP_Matériel AS M INNER JOIN
                         dbo.LP_Monopalme AS Mo ON Mo.ID = M.ID
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "M"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 119
               Right = 246
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mo"
            Begin Extent = 
               Top = 6
               Left = 284
               Bottom = 119
               Right = 492
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vLP_VoirMonopalme'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vLP_VoirMonopalme'
GO

USE [nicolashanon]
GO

/****** Object:  View [dbo].[vLP_VoirStock]    Script Date: 08/06/2023 22:02:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[vLP_VoirStock]
AS
SELECT        M.ID, M.marque, M.Nom, C.Taille, C.saisonCombi, Mo.TypeMono, Mo.pointure
FROM            dbo.LP_Matériel AS M LEFT OUTER JOIN
                         dbo.LP_Combinaison AS C ON M.ID = C.ID LEFT OUTER JOIN
                         dbo.LP_Monopalme AS Mo ON Mo.ID = M.ID
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "M"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 119
               Right = 246
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "C"
            Begin Extent = 
               Top = 158
               Left = 498
               Bottom = 271
               Right = 706
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Mo"
            Begin Extent = 
               Top = 53
               Left = 787
               Bottom = 166
               Right = 995
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vLP_VoirStock'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vLP_VoirStock'
GO

USE [nicolashanon]
GO

/****** Object:  StoredProcedure [dbo].[LP_AjouterCombinaison]    Script Date: 08/06/2023 22:03:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Nicolas.H
-- Create date: 22/03/2023
-- Description:	Insert un nouveau monopalme
-- =============================================
CREATE PROCEDURE [dbo].[LP_AjouterCombinaison]
	-- Add the parameters for the stored procedure here
	@pId int,
	@pMarque varchar(50),
	@pNom varchar(50),
	@pTaille varchar(50),
	@pSaisonCombi varchar(50)
AS
	insert into LP_Matériel values (@pMarque, @pNom);
	insert into LP_Combinaison values (@pId, @pTaille, @pSaisonCombi);
GO

USE [nicolashanon]
GO

/****** Object:  StoredProcedure [dbo].[LP_AjouterMonopalme]    Script Date: 08/06/2023 22:03:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Nicolas.H
-- Create date: 22/03/2023
-- Description:	Insert un nouveau monopalme
-- =============================================
CREATE PROCEDURE [dbo].[LP_AjouterMonopalme] 
	-- Add the parameters for the stored procedure here
	@pId int,
	@pMarque varchar(50),
	@pNom varchar(50),
	@pTypeMono varchar(50),
	@pPointure varchar(50)
AS
	insert into LP_Matériel (marque, Nom) values (@pMarque, @pNom);
	insert into LP_Monopalme values (@pId, @pTypeMono, @pPointure);
GO

USE [nicolashanon]
GO

/****** Object:  StoredProcedure [dbo].[LP_AjouterUnPret]    Script Date: 08/06/2023 22:04:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Nicolas HANON
-- Create date: 29/03/2023
-- Description:	Permet d'inserer un item dans la table pret
-- =============================================
CREATE PROCEDURE [dbo].[LP_AjouterUnPret]
	-- Add the parameters for the stored procedure here
	@pDateEmprunt date,
	@pDateRetourPret date,
	@pID1 int,
	@pID2 int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT into LP_Pret values (@pDateEmprunt, @pDateRetourPret, @pID1, @pID2);
END
GO

USE [nicolashanon]
GO

/****** Object:  StoredProcedure [dbo].[LP_RecupMaterielPret]    Script Date: 08/06/2023 22:04:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:        Nicolas.H
-- Create date: 22/03/2023
-- Description:    Insert un nouveau monopalme
-- =============================================
CREATE PROCEDURE [dbo].[LP_RecupMaterielPret]
    -- Add the parameters for the stored procedure here
    @pId int

AS
    delete from LP_Pret where id= @pId;


GO

USE [nicolashanon]
GO

/****** Object:  StoredProcedure [dbo].[ProcedureNageurChiffree]    Script Date: 08/06/2023 22:04:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ProcedureNageurChiffree]
AS
BEGIN
    -- Appeler la vue
    SELECT *
    FROM dbo.vLP_Nageur_Chiffree;
END
GO

USE [nicolashanon]
GO

/****** Object:  StoredProcedure [dbo].[ProcedureVoirNageur]    Script Date: 08/06/2023 22:04:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ProcedureVoirNageur]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from LP_Nageur
END
GO

USE [nicolashanon]
GO

/****** Object:  StoredProcedure [dbo].[ProcedureVoirPret]    Script Date: 08/06/2023 22:04:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ProcedureVoirPret]
AS
BEGIN
    -- Appeler la vue
    SELECT *
    FROM dbo.vLP_VoirPret;
END
GO

USE [nicolashanon]
GO

/****** Object:  StoredProcedure [dbo].[ProcedureVoirStock]    Script Date: 08/06/2023 22:05:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ProcedureVoirStock]
AS
BEGIN
    -- Appeler la vue
    SELECT marque, Nom, Taille, saisonCombi, TypeMono, pointure
    FROM dbo.vLp_VoirStock;
END
GO

USE [nicolashanon]
GO

/****** Object:  UserDefinedFunction [dbo].[getMaxID]    Script Date: 08/06/2023 22:05:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[getMaxID]()
RETURNS INT
AS
BEGIN
	DECLARE @maxID INT;
	SELECT @maxID = MAX(ID) FROM LP_Matériel;
	RETURN @maxID+1;
END;
GO

USE [nicolashanon]
GO

/****** Object:  UserDefinedFunction [dbo].[GetNextPretID]    Script Date: 08/06/2023 22:05:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[GetNextPretID]()
RETURNS INT
AS
BEGIN
    DECLARE @NextID INT;
    
    SELECT @NextID = MAX(ID) + 1
    FROM LP_Pret;
    
    IF @NextID IS NULL
        SET @NextID = 1;
    
    RETURN @NextID;
END;
GO

