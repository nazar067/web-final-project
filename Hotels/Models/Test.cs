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
                        Description = "Premier Palace is a 5-star hotel in Kyiv, located in the heart of Ukraine's capital. With over 110 years of history, the hotel retains its charm while staying ahead of its time.\n\nThe Premier Palace Hotel Kyiv offers high levels of service and comfort. In 2009, it received six stars and seven stripes from the Stars and Stripes system, a globally recognized organization in the hospitality industry. The hotel's concierge holds the prestigious 'Golden Keys' awarded by Les Clefs d'Or, one of the world's most recognized guilds. Included in the 'TOP Famous Hotels in the World,' it is a must-visit destination on Ukraine's map.",
                        Img = "https://premier-palace.phnr.com/media-shared/premeir-palace-hotel-kyiv.jpeg",
                        Img1 = "https://premier-palace.phnr.com/static/photos/gallery/slider-800x500/22/2218/57209599362a89e841c8db.jpg",
                        Img2 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/5769826.jpg?k=77dcd0cd1981ee78396777d8c567edf53f8e6f3d607af90801d9aee20e4c28c7&o=&hp=1",
                        Img3 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/120551027.jpg?k=ded2debda49efa0cecaae7dfbb42db9c66e75639ee23d62f3359faaeadffc52f&o=&hp=1",
                        Img4 = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1b/Premier_palace_hotel.jpg/800px-Premier_palace_hotel.jpg",
                        Img5 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQWHVxuNItoDyWe1-sUyD1Aq41JPgVQbXtSrQ&s",
                        Img6 = "https://res.klook.com/klook-hotel/image/upload/travelapi/70000000/69950000/69945200/69945111/55e9760f_z.jpg",
                        Contry = "Ukraine",
                        Stars = 5,
                        City = "Kyiv",
                        Lat = 50.442, 
                        Lng = 30.517,
                        Price = 2000
                    },
                    new Hotel
                    {
                        Title = "Opera Hotel",
                        Description = "Opera Hotel is a luxurious boutique hotel ideally located in central Kyiv at the intersection of the business, cultural, and historical districts, just a short walk from major attractions like the Opera House and St. Sophia and St. Volodymyr Cathedrals.\r\n\r\nThis boutique hotel in Kyiv is spacious yet cozy, with special attention to every guest and detail. Opera Hotel features 140 comfortable rooms and suites, elegantly decorated with stylish soft furnishings and luxurious amenities. Our Executive and Junior Suites are beautifully themed around famous opera compositions from various countries (e.g., Madame Butterfly, Boris Godunov), highlighting the character of each culture.\r\n\r\nExperienced travelers will appreciate the hotel's proximity to business establishments and embassies, while enjoying the tranquility of the area and walks to historical and cultural landmarks and numerous shops.",
                        Img = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/13590117.jpg?k=e4abe16cc9f769b1283742396fbf31b15c39fce14866088e31e09a84c41bd56f&o=&hp=1",
                        Img1 = "https://www.hotelvictoiresopera.com/_novaimg/4888275-1478520_0_0_1676_1328_1893_1500.jpg",
                        Img2 = "https://image-tc.galaxy.tf/wijpeg-bfr5r9jhhqw4vyuosghlotkp/day-outside-hotel.jpg?width=860",
                        Img3 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQQLrX8L1TLEWTOu9_acCZhbXQyxJO6x2q2bQ&s",
                        Img4 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/13590645.jpg?k=f9a40ca7a963768b26c347370121c274ee2d91a245dd09d1767b77d6cfc8248c&o=&hp=1",
                        Img5 = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/18/1c/ac/82/opera-hotel-spa.jpg?w=700&h=-1&s=1",
                        Img6 = "https://travelblog.lv/wp-content/uploads/2016/11/hotel_panorama.jpg",
                        Contry = "Ukraine",
                        Stars = 5,
                        City = "Kyiv",
                        Lat = 50.448,
                        Lng = 30.499,
                        Price = 1800
                    },
                    new Hotel
                    {
                        Title = "Rehana Royal Beach",
                        Description = "Rehana Royal Hotel is located in Nabq Bay on the first coastline. Guests can enjoy spacious rooms with balconies offering views of the outdoor pool or Mount Sinai, as well as a private beach on the Red Sea and a spa center.The modern rooms at Rehana Royal Beach Resort are decorated in neutral tones and feature warm - colored fabrics.All rooms include satellite TV and a minibar, while some also offer a Jacuzzi or shower.",
                        Img = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/12/f6/e5/99/rehana-royal-beach-resort.jpg?w=700&h=-1&s=1",
                        Img1 = "https://newimg.otpusk.com/3/800x600/00/04/32/89/4328947.webp",
                        Img2 = "https://img.poehalisnami.ua/static/hotels/egipet/sharm-el-shejjkh/h7187/orig/o3477007187_637723119236910085.jpg",
                        Img3 = "https://rehana-royal-beach-resort-sharm-el-sheikh.hotelmix.com.ua/data/Photos/OriginalPhoto/1165/116545/116545100/Rehana-Royal-Beach-Resort-Aquapark-Spa-Family-Couples-Only-Sharm-el-Sheikh-Exterior.JPEG",
                        Img4 = "https://joinup.ua/media/2015/01/Main-pool-1.jpg",
                        Img5 = "https://img.poehalisnami.ua/static/hotels/egipet/sharm-el-shejjkh/h7187/orig/o3477057187_637723119385500853.jpg",
                        Img6 = "https://newimg.otpusk.com/3/800x600/00/04/32/89/4328947.webp",
                        Contry = "Egypt",
                        Stars = 5,
                        City = "Second Sharm Al Shiekh",
                        Lat = 28.024,
                        Lng = 34.436,
                        Price = 1000
                    },
                    new Hotel
                    {
                        Title = "Concorde El Salam Front Area",
                        Description = "This hotel is located near the beach in Sharm El Sheikh, just a 5-minute walk from Soho Square. Guests can enjoy a panoramic lagoon-shaped pool overlooking the Red Sea, a full-size football field, a private beach, and free Wi-Fi throughout the property.The L’Italiano restaurant offers a wide selection of Italian cuisine, while the Laguna & Terrace restaurant serves international dishes in an outdoor setting with sea views. Additionally, the hotel features a bar with live piano music overlooking the pool area.The Normandy II club hosts live concerts and music from around the world.",
                        Img = "https://joinup.ua/media/2015/12/Concorde-El-Salam-Front-Area-16.jpg.jpg",
                        Img1 = "https://newimg.otpusk.com/3/800x600/00/04/01/70/4017067.webp",
                        Img2 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/13711283.jpg?k=e82f7d6446da1d36b04a1883d83ba8b6717e79b6b6ff1174f9e1b99c08df5ea0&o=&hp=1",
                        Img3 = "https://aventour.ua/wp-content/uploads/2021/04/Concorde-El-Salam-Front-Area-5-e1619013831842.jpg",
                        Img4 = "https://www.celojumubode.lv/uploads/hotel/1/44028-3-concorde-el-salam-front-area-5-5FhQaNapc4.jpg",
                        Img5 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/13711060.jpg?k=034ea759b989e2ccaf0641b0b5a1ce71c8eb6b898884369033bc56c7a5c9aca6&o=&hp=1",
                        Img6 = "https://kompastour.com/useruploads/hotels/hotel_fdbdb288b5.jpg",
                        Contry = "Egypt",
                        Stars = 5,
                        City = "Sharm Al Shiekh",
                        Lat = 27.965,
                        Lng = 34.397,
                        Price = 1100
                    },
                    new Hotel
                    {
                        Title = "Loews Santa Monica Beach Hotel",
                        Description = "The 5-star Regent Santa Monica Beach Hotel is located just a 6-minute walk from the Santa Monica Pier and offers a 24-hour front desk and late check-out options. Guests can relax by the pool or take a stroll along the nearby river, just a 7-minute walk away.",
                        Img = "https://palisadesnews.com/wp-content/uploads/2022/11/lowes-feature-image.jpg",
                        Img1 = "https://media.cntraveler.com/photos/5d5572f566700c0008ca22f0/16:9/w_2560%2Cc_limit/01-LoewsSantaMonicaBeachHotel-2019-Viceroy-2.jpg",
                        Img2 = "https://www.venuereport.com/media/cache/resolve/venue_gallery_big/uploads/2018%252F10%252FTheVenueReport-LoewsSantaMonica-05.jpg",
                        Img3 = "https://loews-santa-monica-beach-hotel.nochi.com.ua/data/Photos/OriginalPhoto/15895/1589558/1589558202/Regent-Santa-Monica-Beach-Hotel-Los-Angeles-Exterior.JPEG",
                        Img4 = "https://solusdecor.co.uk/wp-content/uploads/2017/08/pool.jpg",
                        Img5 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTddfgv8hqMaPBG-80fUfNFPbeYwmlQHALe8Q&s",
                        Img6 = "https://res.cloudinary.com/enchanting/q_70,f_auto,c_fill,g_face/hj-web/2020/10/LAX.A.2011.117573.004.jpg",
                        Contry = "USA",
                        Stars = 5,
                        City = "Santa Monica",
                        Lat = 34.009,
                        Lng = -118.491,
                        Price = 5000
                    },
                    new Hotel
                    {
                        Title = "Hilton Kyiv",
                        Description = "Hilton Kyiv offers comfort, style, and convenience in the heart of Kyiv. It is the perfect choice for both business travelers and tourists. Guests can enjoy a fine-dining restaurant, spa services, a fitness center, and stunning views of the Botanical Garden. The hotel also features numerous conference rooms for business meetings and special events.",
                        Img = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/484067347.jpg?k=54867b5844a5dcff5fcd8e7dd756e04d933b43ae59c01d2822becdd119fd9490&o=&hp=1",
                        Img1 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/484067741.jpg?k=0b71118fa91f74d2946ad79b3f2f05b6a8ba296d84edd0f72a4dbf4db38f6d87&o=&hp=1",
                        Img2 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/484067491.jpg?k=c3123114aaef1b3f5200a3c427a6d9aacd83d5f2249f95d099b0ae1ae88b59e7&o=&hp=1",
                        Img3 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/484067588.jpg?k=5478897aac9673cc9d716e40c1ce6a7cae38587e3cec8ba73e952e23cc5158fc&o=&hp=1",
                        Img4 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/484067382.jpg?k=3074ee055b040a2db47db45a0e1da730e88dcf459c9fb45a64607f8e9d04777d&o=&hp=1",
                        Img5 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/484067415.jpg?k=4ecb67286b96e8bb3416e3f09621d1a63db3547d94f5b1d8418f3b92c576efbe&o=&hp=1",
                        Img6 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/484067469.jpg?k=d1b059aab56943d91f45e47c888bea80c118799833bc2d7ad487921a7f4237e1&o=&hp=1",
                        Contry = "Ukraine",
                        Stars = 5,
                        City = "Kyiv",
                        Lat = 50.445,
                        Lng = 30.504,
                        Price = 2200
                    },

                    new Hotel
                    {
                        Title = "The Ritz-Carlton, Doha",
                        Description = "A luxurious hotel with exquisite rooms, modern design, and stunning views of the Persian Gulf. The Ritz-Carl",
                        Img = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/501145093.jpg?k=ef6e6f0cf116615c25c88ae04a5b4b17afd74bc8198a9c74a1ab3dfb8b8b243b&o=&hp=1",
                        Img1 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/435159296.jpg?k=870a7891228a8c09ed07b50cc123f8398a2908404c0049b02cd901dacce1359c&o=&hp=1",
                        Img2 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/426617804.jpg?k=06c7ed15070ef9b68025693ad7169b5ffbebbf183559f7f041430dc5acf36972&o=&hp=1",
                        Img3 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/502535996.jpg?k=beed27bff132e5cba4f2c9360204f277959a738431c2a26ead4c97f7f3da2ccc&o=&hp=1",
                        Img4 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/426616701.jpg?k=fc80a109d6fd5cba705cde34de140037d1cd674dd57fcf54bd52f1ed5e481bb5&o=&hp=1",
                        Img5 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/426616905.jpg?k=52472ead344641dace6f8f259a8b85b557856271a7b7a8ad361cac8a5579fd85&o=&hp=1",
                        Img6 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/566883953.jpg?k=feccbdf90fdf25282b10700161298055790d7d635a9603e28f538ed1c83a05f0&o=&hp=1",
                        Contry = "Qatar",
                        Stars = 5,
                        City = "Doha",
                        Lat = 25.379,
                        Lng = 51.531,
                        Price = 3500
                    },

                    new Hotel
                    {
                        Title = "Marina Bay Sands",
                        Description = "Seen from the outside, Marina Bay Sands floats above the Singapore skyline, unchanged and timeless. But within, a transformation has blossomed.",
                        Img = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/611676302.jpg?k=f7da568223801ba901ea5ded323f55346bcb1484a6e8dd9202ee63ebe1197990&o=&hp=1",
                        Img1 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/611269193.jpg?k=9c5d23223c7c8b8a1a3f0387c8389d46bf0e1bfd0517452a3ddc7015f826e320&o=&hp=1",
                        Img2 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/611272999.jpg?k=0cfa35997dacefe2ed274bf9e3ec4d864ba48c38d33dd272e8d88b49787bdd4f&o=&hp=1",
                        Img3 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/490217344.jpg?k=d3520a5f62efebf0711681ce7d4e401376fc8bccbe2401bd5f4d560d2ac4d987&o=&hp=1",
                        Img4 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/430789845.jpg?k=628db14e92d0f45cf2c6b449055573e3314ac271913d99788d1f0b0f8fa1631f&o=&hp=1",
                        Img5 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/444700267.jpg?k=a0a9e4217418b535317abbbf9eff716f4fd20b7321c55364c90088a4474e5ff7&o=&hp=1",
                        Img6 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/611270575.jpg?k=a5ef0d9df06aadf2286bfe97bff12b4e7d7506c9ba16de599fa4685331462f70&o=&hp=1",
                        Contry = "Singapore",
                        Stars = 5,
                        City = "Johor Bahru",
                        Lat = 1.283,
                        Lng = 103.859,
                        Price = 4800
                    },

                    new Hotel
                    {
                        Title = "Hotel de Paris Monte-Carlo",
                        Description = "A luxury hotel in the heart of Monte Carlo. Elegant rooms, the famous Louis XV restaurant and a magnificent view of the Mediterranean Sea. The hotel offers ideal conditions for leisure and business. It is a favorite destination for celebrities and those looking for the best service.\n\nFeatures: elegant rooms, Louis XV restaurant, swimming pool, spa services, luxurious sea views.",
                        Img = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/492010980.jpg?k=1d32258413b148a31605360014e9284053d6e3a1203c171979357726ccf94147&o=&hp=1",
                        Img1 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/325405117.jpg?k=a4ee973738a67104462724353ba1881a2fc2f73c69d7a070adeeccdb1af374f8&o=&hp=1",
                        Img2 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/502057158.jpg?k=fd8cc92416ed7c1871b9ac90e3fcf78fb77ff5ec4eeb0e24a4921d0919cbd28f&o=&hp=1",
                        Img3 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/575887312.jpg?k=ea989f7b263e8eaa4c32f755d401e1af3035dc7972cc627717c65ec4f79ecad4&o=&hp=1",
                        Img4 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/243898495.jpg?k=6d6548cf2c956005cf8f836f7ce0540dc95a922c1160f66c78cf6327ab6d1240&o=&hp=1",
                        Img5 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/492012269.jpg?k=842e51186f516a4178289c94730eb3a3068c8aaa875246d080e86daa6959e5cc&o=&hp=1",
                        Img6 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/502057158.jpg?k=fd8cc92416ed7c1871b9ac90e3fcf78fb77ff5ec4eeb0e24a4921d0919cbd28f&o=&hp=1",
                        Contry = "Monaco",
                        Stars = 5,
                        City = "Monte-Carlo",
                        Lat = 43.739,
                        Lng = 7.427,
                        Price = 7000
                    },
                    new Hotel
                    {
                        Title = "The Grand Hotel, Hurghada",
                        Description = "The Grand Hotel, Hurghada is a 4-star hotel on the first line of Hurghada. An outdoor pool, a garden and a private beach are at guests' disposal. Steigenberger Al Dau Beach Facilities include a terrace and a bar. club, food and beverage delivery and currency exchange.\n\nFeatures: elegant rooms, Louis XV restaurant, swimming pool, spa services, luxurious sea views.",
                        Img = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/581212578.jpg?k=f0d4f5676c6b695f48f06fa3da4208f9ead411dfc946a96718e371427caca293&o=&hp=1",
                        Img1 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/463993090.jpg?k=5c78491f089cd130309d1454a22a566950d09f0366e7f44ea6c53a59407ed77d&o=&hp=1",
                        Img2 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/463992170.jpg?k=d4c287cd9cbbaccdc6db8fc46d2315b371f7d1755af91bb9983c1b55a4d428e1&o=&hp=1",
                        Img3 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/463995767.jpg?k=26b4891416a05564db6ebbe8ea89e75f7d64c4b4826df575d98fc2bb593207d7&o=&hp=1",
                        Img4 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/463993364.jpg?k=0860053f3a5af89780aef93f3087ca0ba9945de3f80e0fc393a75e692638df5c&o=&hp=1",
                        Img5 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/463993402.jpg?k=4066e3b786ecb60689b927a01a04823743b3dedb2528ce83748b27cd9585e1c1&o=&hp=1",
                        Img6 = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/463992273.jpg?k=ade8e51939bce369917a82313d32c47f99a35b387fb59622d02e2ccfaf739762&o=&hp=1",
                        Contry = "Egypt",
                        Stars = 4,
                        City = "Hurghada",
                        Lat = 27.174,
                        Lng = 33.824,
                        Price = 2222
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
