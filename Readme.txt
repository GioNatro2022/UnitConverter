
This a generic solution that can support convertions from any unit to another unit.  To Create a new Converter Extend BaseConverter class and provide unit synonims,
conversion logic and validation in the constructor. To use existing converters just create instance of any specific converter and call "PerformConversion" method.
For isntance MeterToInch converter can convert from meter to inch, from inch to meter, from kilometer to meter, from milimeter to meter, etc.. 
argument needs to be provided like this: PerformConversion("10 meters", "inch"). in first argument value and unit should be separated by space. multiple synonims of unit are supported. For example, in this case, "meter", "meters" and "m" are all valid units.   
