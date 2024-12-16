using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotels.Models
{
    public class Test
    {
        public static void Init(HotelsContext context)
        {
            if (!context.Hotels.Any())
            {
                context.Hotels.AddRange(
                    new Hotel
                    {
                        Title = "Premier Palace Hotel",
                        Description = "Прем'єр Палац - це 5-ти зірковий готель в Києві, розташований в самому центрі столиці України. Нашому розкішному готелю понад 110 років і сьогодні він не втрачає свого шарму і здатності випереджати час.\n\nPremier Palace Hotel Kyiv - це готель високого рівня обслуговування та комфорту. У 2009 році він отримав шість зірок і сім смуг від системи Stars and Stripes, всесвітньо відомої організації по визнанню в індустрії гостинності, а консьєрж готелю володіє «Золотими ключами», виданими йому однією з найбільших і визнаних у світі гільдій Les Clefs d'Or. Готель входить в «ТОП найзнаменитіших готелів світу», що робить його важливим місцем на карті України.",
                        Img = "https://premier-palace.phnr.com/media-shared/premeir-palace-hotel-kyiv.jpeg",
                        Img1 = "https://premier-palace.phnr.com/static/photos/gallery/slider-800x500/22/2218/57209599362a89e841c8db.jpg",
                        Img2 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/5769826.jpg?k=77dcd0cd1981ee78396777d8c567edf53f8e6f3d607af90801d9aee20e4c28c7&o=&hp=1",
                        Img3 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/120551027.jpg?k=ded2debda49efa0cecaae7dfbb42db9c66e75639ee23d62f3359faaeadffc52f&o=&hp=1",
                        Img4 = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1b/Premier_palace_hotel.jpg/800px-Premier_palace_hotel.jpg",
                        Img5 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQWHVxuNItoDyWe1-sUyD1Aq41JPgVQbXtSrQ&s",
                        Img6 = "https://res.klook.com/klook-hotel/image/upload/travelapi/70000000/69950000/69945200/69945111/55e9760f_z.jpg",
                        Contry = "Ukraine",
                        Stars = 5,
                        Price = 2000
                    },
                    new Hotel
                    {
                        Title = "Opera Hotel",
                        Description = "Opera Hotel is the luxury boutique hotel ideally located in the heart of Kyiv at the crossroads of the city's business, cultural and historical districts, within walking distance of Kyiv’s main attractions such as the Opera House, St. Sophia's & St. Volodymyr’s Cathedrals.\r\n\r\nThis boutique hotel in Kyiv is spacious yet cosy with special attention to each guest and every detail. Opera Hotel offers 140 comfortable rooms & suites elegantly appointed with stylish soft furnishings and luxury amenities. Our Executive & Junior Suites are beautifully decorated to reflect world-famous opera compositions from different countries (Madame Butterfly, Borys Hodunov etc.) to emphasize the distinctive character of each culture. \r\n\r\nExperienced travellers will appreciate the closeness of Opera Hotel to business entities and embassies at the same time enjoying the quiet area and walks around historical and cultural sights and multiple shopping locations.",
                        Img = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/13590117.jpg?k=e4abe16cc9f769b1283742396fbf31b15c39fce14866088e31e09a84c41bd56f&o=&hp=1",
                        Img1 = "https://www.hotelvictoiresopera.com/_novaimg/4888275-1478520_0_0_1676_1328_1893_1500.jpg",
                        Img2 = "https://image-tc.galaxy.tf/wijpeg-bfr5r9jhhqw4vyuosghlotkp/day-outside-hotel.jpg?width=860",
                        Img3 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQQLrX8L1TLEWTOu9_acCZhbXQyxJO6x2q2bQ&s",
                        Img4 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/13590645.jpg?k=f9a40ca7a963768b26c347370121c274ee2d91a245dd09d1767b77d6cfc8248c&o=&hp=1",
                        Img5 = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/18/1c/ac/82/opera-hotel-spa.jpg?w=700&h=-1&s=1",
                        Img6 = "https://travelblog.lv/wp-content/uploads/2016/11/hotel_panorama.jpg",
                        Contry = "Ukraine",
                        Stars = 5,
                        Price = 1800
                    },
                    new Hotel
                    {
                        Title = "Rehana Royal Beach",
                        Description = "Отель Rehana Royal расположен в заливе Набк на первой береговой линии. К услугам гостей просторные номера с балконами с видом на открытый бассейн или гору Синай, а также частный пляж на берегу Красного моря и спа-салон.\r\n\r\nСовременные номера курортного спа-отеля Rehana Royal Beach оформлены в нейтральных тонах и украшены тканями теплых оттенков. Во всех номерах есть спутниковое телевидение и мини-бар, а в некоторых - гидромассажная ванна или душ.",
                        Img = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/12/f6/e5/99/rehana-royal-beach-resort.jpg?w=700&h=-1&s=1",
                        Img1 = "https://newimg.otpusk.com/3/800x600/00/04/32/89/4328947.webp",
                        Img2 = "https://img.poehalisnami.ua/static/hotels/egipet/sharm-el-shejjkh/h7187/orig/o3477007187_637723119236910085.jpg",
                        Img3 = "https://rehana-royal-beach-resort-sharm-el-sheikh.hotelmix.com.ua/data/Photos/OriginalPhoto/1165/116545/116545100/Rehana-Royal-Beach-Resort-Aquapark-Spa-Family-Couples-Only-Sharm-el-Sheikh-Exterior.JPEG",
                        Img4 = "https://joinup.ua/media/2015/01/Main-pool-1.jpg",
                        Img5 = "https://img.poehalisnami.ua/static/hotels/egipet/sharm-el-shejjkh/h7187/orig/o3477057187_637723119385500853.jpg",
                        Img6 = "https://newimg.otpusk.com/3/800x600/00/04/32/89/4328947.webp",
                        Contry = "Egypt",
                        Stars = 5,
                        Price = 1000
                    },
                    new Hotel
                    {
                        Title = "Concorde El Salam Front Area",
                        Description = "Этот отель расположен рядом с пляжем в городе Шарм-эш-Шейх, всего в 5 минутах ходьбы от площади Сохо. К услугам гостей панорамный бассейн в форме лагуны с видом на Красное море, полноразмерное футбольное поле, частный пляж и бесплатный Wi-Fi на всей территории.\r\n\r\nВ ресторане L’Italiano представлен широкий выбор блюд итальянской кухни. В ресторане Laguna & Terrace с видом на море подают блюда интернациональной кухни на открытом воздухе. Помимо этого, в отеле работает бар с живой фортепианной музыкой, из которого открывается вид на зону бассейна. В клубе Normandy II звучит музыка разных стран мира, а также проходят живые концерты.",
                        Img = "https://joinup.ua/media/2015/12/Concorde-El-Salam-Front-Area-16.jpg.jpg",
                        Img1 = "https://newimg.otpusk.com/3/800x600/00/04/01/70/4017067.webp",
                        Img2 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/13711283.jpg?k=e82f7d6446da1d36b04a1883d83ba8b6717e79b6b6ff1174f9e1b99c08df5ea0&o=&hp=1",
                        Img3 = "https://aventour.ua/wp-content/uploads/2021/04/Concorde-El-Salam-Front-Area-5-e1619013831842.jpg",
                        Img4 = "https://www.celojumubode.lv/uploads/hotel/1/44028-3-concorde-el-salam-front-area-5-5FhQaNapc4.jpg",
                        Img5 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/13711060.jpg?k=034ea759b989e2ccaf0641b0b5a1ce71c8eb6b898884369033bc56c7a5c9aca6&o=&hp=1",
                        Img6 = "https://kompastour.com/useruploads/hotels/hotel_fdbdb288b5.jpg",
                        Contry = "Egypt",
                        Stars = 5,
                        Price = 1100
                    },
                    new Hotel
                    {
                        Title = "Loews Santa Monica Beach Hotel",
                        Description = "5-зірковий готель Regent Santa Monica Beach розташований лише за 6 хвилин ходьби від пірсу Санта-Моніки та має цілодобову стійку реєстрації і пізній виїзд. Проживаючи у готелі, ви зможете відпочити біля басейну та прогулятися вздовж річки, яка протікає на відстані всього лише 7 хвилин ходьби.",
                        Img = "https://palisadesnews.com/wp-content/uploads/2022/11/lowes-feature-image.jpg",
                        Img1 = "https://media.cntraveler.com/photos/5d5572f566700c0008ca22f0/16:9/w_2560%2Cc_limit/01-LoewsSantaMonicaBeachHotel-2019-Viceroy-2.jpg",
                        Img2 = "https://www.venuereport.com/media/cache/resolve/venue_gallery_big/uploads/2018%252F10%252FTheVenueReport-LoewsSantaMonica-05.jpg",
                        Img3 = "https://loews-santa-monica-beach-hotel.nochi.com.ua/data/Photos/OriginalPhoto/15895/1589558/1589558202/Regent-Santa-Monica-Beach-Hotel-Los-Angeles-Exterior.JPEG",
                        Img4 = "https://solusdecor.co.uk/wp-content/uploads/2017/08/pool.jpg",
                        Img5 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTddfgv8hqMaPBG-80fUfNFPbeYwmlQHALe8Q&s",
                        Img6 = "https://res.cloudinary.com/enchanting/q_70,f_auto,c_fill,g_face/hj-web/2020/10/LAX.A.2011.117573.004.jpg",
                        Contry = "USA",
                        Stars = 5,
                        Price = 5000
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
