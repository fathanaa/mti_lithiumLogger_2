void setup() 
{
  Serial.begin(9600);
}

void loop() 
{
    int ite = 1; 
    
    unsigned long data1 = 0x01014359; //16859993
    unsigned long data2 = 0x0102671; //16918129
    unsigned long data3 = 0x01032703; //16918275
    unsigned long data4 = 0x01042185; //16982405
    unsigned long data5 = 0x01053395; //17052565
//    unsigned long data6 = 0x2371; //17113969
//    unsigned long data7 = 0x4064; //17186916
//    unsigned long data8 = 0x3165; //17248613
//    unsigned long data9 = 0x3895; //17315989
//    unsigned long data10 = 0x2628; //17376808
//    unsigned long data11 = 0x2610; //17835536
//    unsigned long data12 = 0x2890; //354734325
//    unsigned long data13 = 0x1865; //340936696 
//    unsigned long data14 = 0x4275; //64777696
//    unsigned long data15 = 0x6229; //870449591
//    unsigned long data16 = 0x4100; //743958359
//    

//    float a = (float)data1/16;       // 295707998 / 16 = 18481749.875
//    float b = a - (int)a;           // 18481749.875 - 18481749 = 0.875
//    int   bit1 = b*16;              // 0.875 * 16 = 14

    

    Serial.println(data1);
    Serial.println(data2);
    Serial.println(data3);
    Serial.println(data4);
    Serial.println(data5);

  delay(1000);
}
