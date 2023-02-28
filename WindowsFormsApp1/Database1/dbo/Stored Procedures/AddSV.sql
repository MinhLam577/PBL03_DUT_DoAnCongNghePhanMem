create proc AddSV
@ClassName nvarchar(50), @Id nvarchar(50), @Name nvarchar(50), @Dtb float, @NS date, @Gender bit,
@Picture bit, @Hb bit, @Cccd bit
as
begin
	Insert into SV(ClassName, Id, Name, Dtb, NS, Gender, Picture, Hb, Cccd)
	values(@ClassName, @Id, @Name, @Dtb, @NS, @Gender, @Picture, @Hb, @Cccd)
end