Insert Into Product_T(ProductID, ProductPicture)
Select '6', BulkColumn 
from Openrowset (Bulk 'C:\Users\liaba\source\repos\TheOffice\printer.jpg', Single_Blob) as Image