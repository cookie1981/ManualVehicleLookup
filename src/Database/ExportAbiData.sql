

SELECT 'INSERT INTO dbo.tblABIData([ABICode],[ProductClass],[Manufacturer],[Model],[Trim],[FullDescription],[EngineCapacity],[EngineSize],[StartYear],[EndYear],[NumberOfDoors],[BodyShape],[FuelType],[Transmission],[LiabilityCategory],[LCVBody],[GrossWeight],[MaxValue],[SecurityDeviceCategory],[GreyImport],[LiabilitySubCategory],[Status],[EffectiveDate],[BodyStyle],[EngineDescription],[ShortDescription],[SequenceNumber]) VALUES(' + 
	CAST([ABICode] as varchar(8)) + ''',''' +	 
	[ProductClass] + ''',''' + 
	[Manufacturer] + ''',''' + 
	[Model] + ''',''' + 
	[Trim] + ''',''' +
	[FullDescription] + ''',''' +
	EngineCapacity + ''',''' + 
	EngineSize + ''',' + 
	CAST(StartYear AS varchar(4)) + ',' + 
	CAST(EndYear AS varchar(4)) + ',' + 
	NumberOfDoors + ''',''' + 
	BodyShape + ''',''' + 
	FuelType + ''',''' + 
	Transmission + ''',''' + 
	LiabilityCategory + ''',''' + 
	LCVBody + ''',' + 
	CAST(GrossWeight AS varchar(4)) + ',' + 
	CAST(MaxValue AS varchar(4))  + ',''' + 
	SecurityDeviceCategory + ''',''' + 
	GreyImport + ''',''' + 
	LiabilitySubCategory + ''',''' + 
	[Status] + ''',''' + 
	[EffectiveDate] + ''',''' + 
	[BodyStyle] + ''',''' + 
	[EngineDescription] + ''',''' + 
	[ShortDescription] + ''',' +
	CAST([SequenceNumber] AS varchar(3))+ ')' 
	
	FROM [dbo].[tblABIData]

	
