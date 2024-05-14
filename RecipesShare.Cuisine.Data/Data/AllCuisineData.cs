namespace RecipesShare.Cuisine.Data.Data
{
    public class AllCuisineData
    {
        public Dictionary<string, string> cuisines;

        public AllCuisineData()
        {
            cuisines = new Dictionary<string, string>()
            {
                ["American"] = "https://media.istockphoto.com/id/531564300/photo/homemade-memorial-day-hamburger-picnic.jpg?s=612x612&w=0&k=20&c=GnsgW8Yy3Sw2jNBLhSV5tWxNZIw-mCeK4J-ZcDoS-cs=",
                ["Angolan"] = "https://www.travelingeast.com/wp-content/uploads/2013/04/Depositphotos_129910734_xl-2015-scaled.jpg",
                ["Arab"] = "https://t4.ftcdn.net/jpg/05/71/62/87/360_F_571628737_JhvTRq1BVqtOoluqS0F5nvhVYRShQoMm.jpg",
                ["Argentine"] = "https://images.immediate.co.uk/production/volatile/sites/30/2014/01/bavette-with-chimichurri-sauce-ef63877.jpg?quality=90&fit=700,466",
                ["Australian"] = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcScn-vrGv7UBJcogUED86FvAHi5892mIzP70uB3jZCu9oLcNSYUMY6U18K7b6MebSy-2OM&usqp=CAU",
                ["Austrian"] = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTJLvuDE9TA6LHYecTy81bqEiwPl_64O4JnltY5KHDLwPv30YLosxelBPAea-xQdPM95VA&usqp=CAU",
                ["Belgian"] = "https://nextstopbelgium.com/wp-content/uploads/2023/08/Moules-Frites.jpg",
                ["Bosnian"] = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcThS0wQO2WUf0eHED3yelpgGeDXUAjZyRIArNMoivSqUNc6G4AQLuszuaADIxJ8pA6n460&usqp=CAU",
                ["Brazilian"] = "https://media.tacdn.com/media/attractions-splice-spp-674x446/0b/ff/55/ff.jpg",
                ["Cambodian"] = "https://www.areacambodia.com/wp-content/uploads/2023/10/Maedy-Khmer-Food-Local-Traditional-Khmer-Restaurant-in-Siem-Reap.jpg",
                ["Canadian"] = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ37xQ3Qaaw851oYSemxXTOOpubXYd-jtZDOtEG-63gHHmDu_fx5vafqhQNvbg-EY5iQ4w&usqp=CAU",
                ["Chilean"] = "https://domesticfits.com/wp-content/uploads/2023/08/chilean-food-international-640x427.jpeg",
                ["Chinese"] = "https://asiasociety.org/files/160802_chinese_food.jpg",
                ["Colombian"] = "https://www.savoredjourneys.com/wp-content/uploads/2017/12/corn-soup.jpg",
                ["Congolese"] = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQP9St7OIT3BRHcGOmjj4Nc8gtIY5KhD-U07UdZmChf2Uet9NeY4154GEVbPdYgM0oG16o&usqp=CAU",
                ["Croatian"] = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTwCHGTdBIebuzAmWQY7Vqy5-uQ_zqwLjEK8P5iJQ7RYDv0QQJWC2-N_nFE2Jj5b6yTHiY&usqp=CAU",
                ["Czech"] = "https://www.cooklikeczechs.com/wp-content/uploads/2020/03/czech-rajska-omacka-with-bread-dumplings.jpg",
                ["Dutch"] = "https://admin.expatica.com/nl/wp-content/uploads/sites/3/2023/11/dutch-food.jpg",
                ["Egyptian"] = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSQmgkZtmhTWYR45Ep3heet8pnSJQ1Q9j-6_jTOaKEg283kuY6XBHgHz8Orbi9GlzIjDdM&usqp=CAU",
                ["Ethiopian"] = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR8jWVWYWXlwcpkvC4j5p1U-SVuZfHgPbR9sbAEWPM1cUl67mfTMKUFOmnMZXgjGfXshrI&usqp=CAU",
                ["Filipino"] = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTwRcSPH4IBnc6G0UUEGtKNtOKhz43VepjS0_ze_q1WYBc57skUNMRCvbhhJrWGjnJBGY4&usqp=CAU",
                ["Finnish"] = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTKmRyBjrZiBMoSUBusw6kWkW8_Js3exwCqodvCgD_C4MSJmyeD82emgX_EY40_C7xykZo&usqp=CAU",
                ["German"] = "https://www.thespruceeats.com/thmb/xMQI-KoTgI4MBExDCN8YhOfcebc=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/GettyImages-697310048-594c507f5f9b58f0fcb236f0.jpg",
                ["Greek"] = "https://itsallgreektome.london/wp-content/uploads/2019/02/Greek-cuisine-ancient.jpg",
                ["Hungarian"] = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR4EESDAVCBSU6TcvwdFgNNykBpioM0Q3pUmnIemo7wOw8EuAUEj_zzZzzXpI1Ym7YebEw&usqp=CAU",
                ["Indian"] = "https://images.squarespace-cdn.com/content/v1/612d4825ee7c3b7ba3e215b7/1667458982443-N6XGU1PU7335QEMVUP7M/Delicious+food.png",
                ["Indonesian"] = "https://bahasabule.com/wp-content/uploads/2023/07/Indonesian-Cuisine-1024x683.jpg",
                ["Irish"] = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQpgbkQmtjcGJUZNxJCCVcumLsz6fv8Scmz4O2473BVpg&s",
                ["Israeli"] = "https://www.themanual.com/wp-content/uploads/sites/9/2019/03/shakshuka-brunch-at-haachim-restaurant-tel-aviv-v2.jpg?p=1",
                ["Italian"] = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRY4-c5SbXfYNS-1KhQtjrLg5allnHdBWask9BRiO2FTA&s",
                ["Jamaican"] = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSnm0utjO7krhv64TIAZjAqeimmfQ929Dn3mGbnoxvQUQ&s",
                ["Japanese"] = "https://static1.squarespace.com/static/5e484ab628c78d6f7e602d73/5e484d29dd42c458f31f0b22/6400f6273d5a3e62aa0d099f/1685393656935/famous-japanese-food-sushi.jpg?format=1500w",
                ["Kazakh"] = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSJOwaqoY7ZIThXpzdPW-ikI_IqebXPeBtOT78FK6nusw&s",
                ["Kenyan"] = "https://www.kenyasafari.com/images/ugali-nyama-choma-590x390.jpg",
                ["Korean"] = "https://a.cdn-hotels.com/gdcs/production50/d1916/51d76cc9-cbe8-4572-a671-545f882f1847.jpg?impolicy=fcrop&w=800&h=533&q=medium",
                ["Malagasy"] = "https://pbs.twimg.com/media/EfxS2G0WkAEbdkX.jpg",
                ["Malaysian"] = "https://www.christineabroad.com/images//2016/11/malaysian-food.jpg",
                ["Mexican"] = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/0b/8c/d2/b4/al-pastor-tacos.jpg?w=600&h=-1&s=1",
                ["Mongolian"] = "https://mongolianstore.com/wp-content/uploads/2017/09/Mongolian-Food.jpg",
                ["New Zealand"] = "https://www.willflyforfood.net/wp-content/uploads/2022/05/new-zealand-food-mussels.jpg.webp",
                ["Nigerian"] = "https://blog.remitly.com/wp-content/uploads/2022/09/different-Nigerian-dishes.jpeg",
                ["Norwegian"] = "https://d2d9hom4y5lr0f.cloudfront.net/2020/11/FARIKAL-AdobeStock_197945012-What-is-Norwegian-Food-Your-Ultimate-Guide-to-Eating-in-Norway-Scandinavia-Standard.jpg",
                ["Pacific"] = "https://a.cdn-hotels.com/gdcs/production65/d21/88a9b9db-8719-45fc-93c3-e6a3165924fb.jpg?impolicy=fcrop&w=800&h=533&q=medium",
                ["Pakistani"] = "https://upload.wikimedia.org/wikipedia/commons/c/c4/Pakistani_Food_Karahi_Beef.jpg",
                ["Peruvian"] = "https://www.livingoutlau.com/wp-content/uploads/2021/05/Causa-Rellena-Peru.jpg",
                ["Polish"] = "https://www.willflyforfood.net/wp-content/uploads/2022/12/polish-food-pierogi.jpg.webp",
                ["Portuguese"] = "https://foodandroad.com/wp-content/uploads/2021/04/pratos-bacalhau-1-768x512.jpg",
                ["Serbian"] = "https://www.willflyforfood.net/wp-content/uploads/2021/12/serbian-food-sarma.jpg",
                ["Russian"] = "https://t3.ftcdn.net/jpg/03/32/64/20/360_F_332642098_RAKyCz9LWHbsMg7xboIBjh58Z7yp8RTP.jpg",
                ["Singaporean"] = "https://sethlui.com/wp-content/uploads/2020/08/Laifabar-5.jpg",
                ["Slovak"] = "https://careergappers.com/wp-content/uploads/2018/09/Svickova-na-smetane-1024x683.jpg",
                ["Slovenian"] = "https://www.minimalistjourneys.com/wp-content/uploads/slovenian-dish-by-klara-avsenikon-unsplash.jpg",
                ["South African"] = "https://images.immediate.co.uk/production/volatile/sites/30/2015/04/Cape-Malay-curry-f938908.jpg?quality=90&fit=700,466",
                ["Spanish"] = "https://img.jamieoliver.com/home/wp-content/uploads/2023/09/2.A_Flying_Visit_To_Spain.jpeg",
                ["Swedish"] = "https://nomadsunveiled.com/wp-content/uploads/2022/09/traditional-swedish-food-in-swden.jpg",
                ["Thai"] = "https://images-cdn.welcomesoftware.com/Zz0zZmEwYTlmODJhZTIxMWVjODdjYWU2ZTYxNWJmMmRjNQ==/Zz0zMTc5YWIwZTBmZmYxMWVjOTBiZDJmOGY5N2ZjYjVhMA%3D%3D.jpg?width=1366",
                ["Turkish"] = "https://idsb.tmgrup.com.tr/ly/uploads/images/2021/03/21/thumbs/800x531/101520.jpg",
                ["Ukrainian"] = "https://domesticfits.com/wp-content/uploads/2024/02/ukrainian-food-facts-640x427.jpeg",
                ["Venezuelan"] = "https://blog.amigofoods.com/wp-content/uploads/2019/07/Venezuelan-Arepa-Pabellon.jpg",
                ["Vietnamese"] = "https://media.urbanistnetwork.com/saigoneer/article-images/legacy/ziX7yolb.jpg",

            };
        }

        public Dictionary<string, string> Cuisines => cuisines;

    }
}
