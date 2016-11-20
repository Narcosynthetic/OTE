USE [DiaxeirhshExoplismouOTE]
GO
/****** Object:  StoredProcedure [dbo].[GetModems]    Script Date: 20/11/2016 6:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[GetModems] 
(
	@userId int,
	@hmeromhniaElenxouApo datetime,
	@hmeromhniaElenxouEos datetime,
	@serialNumber nvarchar(50),
	@ordering nvarchar(50)
)
AS
BEGIN
	SET NOCOUNT ON;
			
	SELECT m.[Id]
      ,m.[Sap] [SapId]
	  ,s.[Sap]
      ,m.[SerialNumber]
	  ,m.[OkOffUpdate] [StatusId]
	  ,st.[StatusDescr] [Status]
	  ,m.[Paratiriseis]

  FROM [dbo].[TechModem] m 
  LEFT JOIN [dbo].[SAP] s ON m.Sap = s.Id
  LEFT JOIN [dbo].[Status] st ON m.[OkOffUpdate] = st.Id

  WHERE (m.[UserId] = @userId OR @userId is null)
  AND (m.[HmeromhniaElenxou] >= @hmeromhniaElenxouApo OR @hmeromhniaElenxouApo = '1900-01-01')  
  AND (m.[HmeromhniaElenxou] <= DATEADD(s, -1, DATEADD(day, 1, DATEADD(day, DATEDIFF(day, 0, @hmeromhniaElenxouEos), 0))) OR @hmeromhniaElenxouEos  = '1900-01-01')
  AND (m.[SerialNumber] = @serialNumber OR @serialNumber = '')

  ORDER BY
  case when @ordering = 'Id asc' THEN m.Id END ASC ,
  case when @ordering = 'Id desc' THEN m.Id END DESC  ,
  case when @ordering = 'HmeromhniaElenxou asc' THEN m.[HmeromhniaElenxou] END ASC,
  case when @ordering = 'HmeromhniaElenxou desc' THEN m.[HmeromhniaElenxou] END DESC
     
END