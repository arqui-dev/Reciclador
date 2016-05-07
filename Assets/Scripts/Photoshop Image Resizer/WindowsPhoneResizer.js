// get a reference to the current (active) document and store it in a variable named "doc"
doc = app.activeDocument;

var sizes = {
	// store logos
	50, 63, 70, 75, 90, 100, 120, 200,
	// windows tiles and logos
	24, 30, 42, 54,
	120, 150, 210, 270,
	56, 70, 98, 126,
	248, 310, 434, 558,
	// windows phone tiles and logos
	44, 62, 106,
	71, 99, 170,
	150, 210, 360
};

for (var i = 0; i < sizes.length; i++)
{
	doc.resizeImage(UnitValue(sizes[i],"px"),null,null,ResampleMethod.BICUBIC);
	var options = new ExportOptionsSaveForWeb();
	options.quality = 100;
	options.format = SaveDocumentType.PNG;
	options.optimized = true;
	doc.exportDocument(File(doc.path+'/'+doc.name+'/'+'Resize_'+sizes[i]),ExportType.SAVEFORWEB,options);
}
//doc.resizeImage(UnitValue(fWidthBig,"px"),null,null,ResampleMethod.BICUBIC);

