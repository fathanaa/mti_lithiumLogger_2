void setup() 
{
  Serial.begin(9600);
}

void loop() 
{
    
    unsigned long data1 = 0x01014359; //16859993
    unsigned long data2 = 0x0102671; //16918129
    unsigned long data3 = 0x01032703; //16918275
    unsigned long data4 = 0x01042185; //16982405
    unsigned long data5 = 0x01053395; //17052565
    unsigned long data6 = 0x01062371; //17113969
    unsigned long data7 = 0x01074064; //17186916
    unsigned long data8 = 0x01083165; //17248613
    unsigned long data9 = 0x01093895; //17315989
    unsigned long data10 = 0x01102628; //17376808
    unsigned long data11 = 0x01112610; //17835536
    unsigned long data12 = 0x01122890; //354734325
    unsigned long data13 = 0x01131865; //340936696 
    unsigned long data14 = 0x01144275; //64777696
    unsigned long temp = 0x01156229; //870449591
    unsigned long arus = 0x01164100; //743958359
    

//    float a = (float)data1/16;       // 295707998 / 16 = 18481749.875
//    float b = a - (int)a;           // 18481749.875 - 18481749 = 0.875
//    int   bit1 = b*16;              // 0.875 * 16 = 14

    

    Serial.println(data1);
    Serial.println(data2);
    Serial.println(data3);
    Serial.println(data4);
    Serial.println(data5);
    Serial.println(data6);
    Serial.println(data7);
    Serial.println(data8);
    Serial.println(data9);
    Serial.println(data10);
    Serial.println(data11);
    Serial.println(data12);
    Serial.println(data13);
    Serial.println(data14);
    Serial.println(temp);
    Serial.println(arus);
    

  delay(1000);
}
