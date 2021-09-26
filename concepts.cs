using System;
 
namespace Examples{

    public class Array{

        public static void ReSiize(ref int[] source,int reSize){

            int[] temp =new int[reSize];
            for(int i=0;i<source.Length;i++){

                temp[i]=source[i];
            }
            source=temp;
        }
    }

    public class DynamicIntegerArray{

        private int[] buffer=new int[5];
		private int itemsCount, capacity;

        /*public void Set_Item(int index,int item){  

            if(index>=buffer.Length){

                Array.ReSiize(ref buffer,index +10);
            }
          buffer[index]=item;
			itemsCount++;
        }

        public int Get_Item(int index){

            return buffer[index];
        }*/
		
		public int ItemsCount
		{
			get
			{
				return this.itemsCount;
			}
			/*set
			{
				itemsCount = buffer.Length;
			}*/
		}
		
		public int Capacity
		{
			get
			{
				return buffer.Length;
			}
		}
		
		public int this[int index]
		{
			get{
				return buffer[index];
			}
			
			set{
				if(index>=buffer.Length){

                Array.ReSiize(ref buffer,index +10);
            }
			buffer[index] = value;
			itemsCount++;
				
			}
		}
        public void Clear(){


        }
    }

    public class Program{

    public static  void Main(){

        DynamicIntegerArray _intArray=new DynamicIntegerArray();
		 _intArray[0]=10;
		 _intArray[1]=20;
		 _intArray[2]=30;
		 _intArray[3]=40;
		 _intArray[4]=50;
		 _intArray[5]=60;
		 _intArray[6]=70;
		 _intArray[7]=80;
		 _intArray[8]=90;
        //_intArray.Set_Item(0,10); // _intArray[0]=10;
       // _intArray.Set_Item(1,20);
        /*_intArray.Set_Item(2,40);
        _intArray.Set_Item(3,50);
        _intArray.Set_Item(4,60);
        _intArray.Set_Item(5,70);//Exception
        _intArray.Set_Item(6,80);
        _intArray.Set_Item(7,90);
        _intArray.Set_Item(8,100);*/

        int _value=_intArray[8];
        //int _value=_intArray.Get_Item(8);
        Console.WriteLine(_value);
        Console.WriteLine(_intArray.ItemsCount);
        Console.WriteLine(_intArray.Capacity);
    }

    }
 
}
