using Microsoft.EntityFrameworkCore;

namespace NationalPark.Models
{
  public class NationalParkContext : DbContext
  {
    public NationalParkContext(DbContextOptions<NationalParkContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
          .HasData(
            new Park
            {
              ParkId = 1,
              Name = "Acadia",
              State = "Maine",
              Coordinates = "44°21'N 68°13'W / 44.35°N 68.21°W",
              Established = "26-Feb-19",
              Area = "47,389.67 acres (191.8†km2)",
              Description = "Covering most of Mount Desert Island and other coastal islands, Acadia features the tallest mountain on the Atlantic coast of the United States, granite peaks, ocean shoreline, woodlands, and lakes. There are freshwater, estuary, forest, and intertidal habitats."
            },
            new Park
            {
              ParkId = 2,
              Name = "American Samoa",
              State = "American Samoa",
              Coordinates = "14°15'S 170°41'W / 14.25°S 170.68°W",
              Established = "31-Oct-88",
              Area = "9,000.00 acres (36.4†km2)",
              Description = "The southernmost national park is on three Samoan islands and protects coral reefs, rainforests, volcanic mountains, and white beaches. The area is also home to flying foxes, brown boobies, sea turtles, and 900 species of fish."
            },
            new Park
            {
              ParkId = 3,
              Name = "Arches",
              State = "Utah",
              Coordinates = "38°41'N 109°34'W / 38.68°N 109.57°W",
              Established = "12-Nov-71",
              Area = "76,518.98 acres (309.7†km2)",
              Description = "This site features more than 2,000 natural sandstone arches, including the Delicate Arch. In a desert climate millions of years of erosion have led to these structures, and the arid ground has life-sustaining soil crust and potholes, natural water-collecting basins. Other geologic formations are stone columns, spires, fins, and towers."
            },
            new Park
            {
              ParkId = 4,
              Name = "Badlands",
              State = "South Dakota",
              Coordinates = "43°45'N 102°30'W / 43.75°N 102.50°W",
              Established = "10-Nov-78",
              Area = "242,755.94 acres (982.4†km2)",
              Description = "The Badlands are a collection of buttes, pinnacles, spires, and grass prairies. It has the world's richest fossil beds from the Oligocene epoch, and there is wildlife including bison, bighorn sheep, black-footed ferrets, and swift foxes."
            },
            new Park
            {
              ParkId = 5,
              Name = "Big Bend",
              State = "Texas",
              Coordinates = "29°15'N 103°15'W / 29.25°N 103.25°W",
              Established = "12-Jun-44",
              Area = "801,163.21 acres (3,242.2†km2)",
              Description = "Named for the Bend of the Rio Grande along the USñMexico border, this park includes a part of the Chihuahuan Desert. A wide variety of Cretaceous and Tertiary fossils as well as cultural artifacts of Native Americans exist within its borders."
            },
            new Park
            {
              ParkId = 6,
              Name = "Biscayne",
              State = "Florida",
              Coordinates = "25°39'N 80°05'W / 25.65°N 80.08°W",
              Established = "28-Jun-80",
              Area = "172,924.07 acres (699.8†km2)",
              Description = "Located in Biscayne Bay, this park at the north end of the Florida Keys has four interrelated marine ecosystems: mangrove forest, the Bay, the Keys, and coral reefs. Threatened animals include the West Indian Manatee, American crocodile, various sea turtles, and peregrine falcon."
            },
            new Park
            {
              ParkId = 7,
              Name = "Black Canyon of the Gunnison",
              State = "Colorado",
              Coordinates = "38°34'N 107°43'W / 38.57°N 107.72°W",
              Established = "21-Oct-99",
              Area = "32,950.03 acres (133.3†km2)",
              Description = "The park protects a quarter of the Gunnison River, which has dark canyon walls from the Precambrian era. The canyon has very steep descents, and it is a site for river rafting and rock climbing. The narrow, steep canyon, made of gneiss and schist, is often in shadow, appearing black."
            },
            new Park
            {
              ParkId = 8,
              Name = "Bryce Canyon",
              State = "Utah",
              Coordinates = "37°34'N 112°11'W / 37.57°N 112.18°W",
              Established = "25-Feb-28",
              Area = "35,835.08 acres (145.0†km2)",
              Description = "Bryce Canyon is a giant natural amphitheatre along the Paunsaugunt Plateau. The unique area has hundreds of tall hoodoos formed by erosion. The region was originally settled by Native Americans and later by Mormon pioneers."
            },
            new Park
            {
              ParkId = 9,
              Name = "Canyonlands",
              State = "Utah",
              Coordinates = "38°12'N 109°56'W / 38.2°N 109.93°W",
              Established = "12-Sep-64",
              Area = "337,597.83 acres (1,366.2†km2)",
              Description = "This landscape was eroded into canyons, buttes, and mesas by the Colorado River, Green River, and their tributaries, which divide the park into three districts. There are rock pinnacles and other naturally sculpted rock, as well as artifacts from Ancient Pueblo Peoples."
            },
            new Park
            {
              ParkId = 10,
              Name = "Capitol Reef",
              State = "Utah",
              Coordinates = "38°12'N 111°10'W / 38.20°N 111.17°W",
              Established = "18-Dec-71",
              Area = "241,904.26 acres (979.0†km2)",
              Description = "The park's Waterpocket Fold is a 100-mile (160†km) monocline that shows the Earth's geologic layers. Other natural features are monoliths and sandstone domes and cliffs shaped like the United States Capitol."
            },
            new Park
            {
              ParkId = 11,
              Name = "Carlsbad Caverns",
              State = "New Mexico",
              Coordinates = "32°10'N 104°26'W / 32.17°N 104.44°W",
              Established = "5/14/1930",
              Area = "46,766.45 acres (189.3†km2)",
              Description = "Carlsbad Caverns has 117 caves, the longest of which is over 120 miles (190†km) long. The Big Room is almost 4,000 feet (1,200†m) long, and the caves are home to over 400,000 Mexican Free-tailed Bats and sixteen other species. Above ground are the Chihuahuan Desert and Rattlesnake Springs."
            },
            new Park
            {
              ParkId = 12,
              Name = "Channel Islands",
              State = "California",
              Coordinates = "34°01'N 119°25'W / 34.01°N 119.42°W",
              Established = "5-Mar-80",
              Area = "249,561.00 acres (1,009.9†km2)",
              Description = "Five of the eight Channel Islands are protected, and half of the park's area is underwater. The islands have a unique Mediterranean ecosystem. They are home to over 2,000 species of land plants and animals, and 145 are unique to them. The islands were originally settled by the Chumash people."
            },
            new Park
            {
              ParkId = 13,
              Name = "Congaree",
              State = "South Carolina",
              Coordinates = "33°47'N 80°47'W / 33.78°N 80.78°W",
              Established = "10-Nov-03",
              Area = "26,545.86 acres (107.4†km2)",
              Description = "On the Congaree River, this park is the largest portion of old-growth floodplain forest left in North America. Some of the trees are the tallest in the Eastern US, and the Boardwalk Loop is an elevated walkway through the swamp."
            },
            new Park
            {
              ParkId = 14,
              Name = "Crater Lake",
              State = "Oregon",
              Coordinates = "42°56'N 122°06'W / 42.94°N 122.1°W",
              Established = "5/22/2002",
              Area = "183,224.05 acres (741.5†km2)",
              Description = "Crater Lake lies in the caldera of Mount Mazama formed 7,700 years ago after an eruption. It is the deepest lake in the United States and is known for its blue color and water clarity. There are two islands in the lake, and, with no inlets or outlets, all water comes through precipitation."
            },
            new Park
            {
              ParkId = 15,
              Name = "Cuyahoga Valley",
              State = "Ohio",
              Coordinates = "41°14'N 81°33'W / 41.24°N 81.55°W",
              Established = "11-Oct-00",
              Area = "32,860.73 acres (133.0†km2)",
              Description = "This park along the Cuyahoga River has waterfalls, hills, trails, and displays about early rural living. The Ohio and Erie Canal Towpath Trail follows the Ohio and Erie Canal, where mules towed canal boats. The park has numerous historic homes, bridges, and structures. The park also offers a scenic train ride with various trips available."
            },
            new Park
            {
              ParkId = 16,
              Name = "Death Valley",
              State = "California, Nevada",
              Coordinates = "36°14'N 116°49'W / 36.24°N 116.82°W",
              Established = "31-Oct-94",
              Area = "3,372,401.96 acres (13,647.6†km2)",
              Description = "Death Valley is the hottest, lowest, and driest place in the United States. Daytime temperatures have topped 130°F (54°C) and it is home to Badwater Basin, the lowest point in North America. There are canyons, colorful badlands, sand dunes, mountains, and over 1000 species of plants in this graben on a fault line. Further geologic points of interest are salt flats, springs, and buttes."
            },
            new Park
            {
              ParkId = 17,
              Name = "Denali",
              State = "Alaska",
              Coordinates = "63°20'N 150°30'W / 63.33°N 150.50°W",
              Established = "26-Feb-17",
              Area = "4,740,911.72 acres (19,185.8†km2)",
              Description = "Centered around the Mount McKinley, the tallest mountain in North America, Denali is serviced by a single road leading to Wonder Lake. McKinley and other peaks of the Alaska Range are covered with long glaciers and boreal forest. Wildlife includes grizzly bears, Dall sheep, caribou, and gray wolves."
            },
            new Park
            {
              ParkId = 18,
              Name = "Dry Tortugas",
              State = "Florida",
              Coordinates = "24°38'N 82°52'W / 24.63°N 82.87°W",
              Established = "26-Oct-92",
              Area = "64,701.22 acres (261.8†km2)",
              Description = "The Dry Tortugas on the west end of the Florida Keys are the site of Fort Jefferson, the largest masonry structure in the Western Hemisphere. With most of the park being water, it is the home of coral reefs and shipwrecks and is only accessible by plane or boat."
            },
            new Park
            {
              ParkId = 19,
              Name = "Everglades",
              State = "Florida",
              Coordinates = "25°19'N 80°56'W / 25.32°N 80.93°W",
              Established = "5/30/1934",
              Area = "1,508,537.90 acres (6,104.8†km2)",
              Description = "The Everglades are the largest subtropical wilderness in the United States. This mangrove ecosystem and marine estuary is home to 36 protected species, including the Florida panther, American crocodile, and West Indian manatee. Some areas have been drained and developed; restoration projects aim to restore the ecology."
            },
            new Park
            {
              ParkId = 20,
              Name = "Gates of the Arctic",
              State = "Alaska",
              Coordinates = "67°47'N 153°18'W / 67.78°N 153.30°W",
              Established = "2-Dec-80",
              Area = "7,523,897.74 acres (30,448.1†km2)",
              Description = "This northernmost park protects part of the Brooks Range and has no park facilities. The land is home to Alaska natives, who have relied on the land and caribou for 11,000 years."
            },
            new Park
            {
              ParkId = 21,
              Name = "Glacier",
              State = "Montana",
              Coordinates = "48°48'N 114°00'W / 48.80°N 114.00°W",
              Established = "5/11/2010",
              Area = "1,013,572.41 acres (4,101.8†km2)",
              Description = "Part of Waterton Glacier International Peace Park, this park has 26 remaining glaciers and 130 named lakes under the tall Rocky Mountain peaks. There are historic hotels and a landmark road in this region of rapidly receding glaciers. These mountains, formed by an overthrust, have the world's best sedimentary fossils from the Proterozoic era."
            },
            new Park
            {
              ParkId = 22,
              Name = "Glacier Bay",
              State = "Alaska",
              Coordinates = "58°30'N 137°00'W / 58.50°N 137.00°W",
              Established = "2-Dec-80",
              Area = "3,224,840.31 acres (13,050.5†km2)",
              Description = "Glacier Bay has numerous tidewater glaciers, mountains, and fjords. The temperate rainforest and the bay are home to grizzly bears, mountain goats, whales, seals, and eagles. When discovered in 1794 by George Vancouver, the entire bay was covered by ice, but the glaciers have receded over 65 miles (105†km)."
            },
            new Park
            {
              ParkId = 23,
              Name = "Grand Canyon",
              State = "Arizona",
              Coordinates = "36°04'N 112°08'W / 36.06°N 112.14°W",
              Established = "26-Feb-19",
              Area = "1,217,403.32 acres (4,926.7†km2)",
              Description = "The Grand Canyon, carved out by the Colorado River, is 277 miles (446†km) long, up to 1 mile (1.6†km) deep, and up to 15 miles (24†km) wide. Millions of years of exposure has formed colorful layers of the Colorado Plateau in mesas and canyon walls."
            },
            new Park
            {
              ParkId = 24,
              Name = "Grand Teton",
              State = "Wyoming",
              Coordinates = "43°44'N 110°48'W / 43.73°N 110.80°W",
              Established = "26-Feb-29",
              Area = "309,994.66 acres (1,254.5†km2)",
              Description = "Grand Teton is the tallest mountain in the Teton Range. The park's Jackson Hole valley and reflective piedmont lakes contrast with the tall mountains, which abruptly rise from the sage-covered valley."
            },
            new Park
            {
              ParkId = 25,
              Name = "Great Basin",
              State = "Nevada",
              Coordinates = "38°59'N 114°18'W / 38.98°N 114.30°W",
              Established = "27-Oct-86",
              Area = "77,180.00 acres (312.3†km2)",
              Description = "Based around Wheeler Peak, the Great Basin has 5,000-year-old bristlecone pines, glacial moraines, and the limestone Lehman Caves. It has some of the country's darkest night skies, and there are animal species including Townsend's big-eared bat, Pronghorn, and Bonneville cutthroat trout."
            },
            new Park
            {
              ParkId = 26,
              Name = "Great Sand Dunes",
              State = "Colorado",
              Coordinates = "37°44'N 105°31'W / 37.73°N 105.51°W",
              Established = "13-Sep-04",
              Area = "42,983.74 acres (173.9†km2)",
              Description = "The tallest dunes in North America are up to 750 feet (230†m) tall and neighbor grasslands, shrublands and wetlands. They were formed by sand deposits of the Rio Grande on the San Luis Valley. The park also has alpine lakes, six 13,000-foot mountains, and ancient forests."
            },
            new Park
            {
              ParkId = 27,
              Name = "Great Smoky Mountains",
              State = "North Carolina, Tennessee",
              Coordinates = "35°41'N 83°32'W / 35.68°N 83.53°W",
              Established = "15-Jun-34",
              Area = "521,490.13 acres (2,110.4†km2)",
              Description = "The Great Smoky Mountains, part of the Appalachian Mountains, have a wide range of elevations, making them home to over 400 vertebrate species, 100 tree species, and 5000 plant species. Hiking is the park's main attraction, with over 800 miles (1,300†km) of trails, including 70 miles (110†km) of the Appalachian Trail. Other activities are fishing, horseback riding, and visiting some of nearly 80 historic structures."
            },
            new Park
            {
              ParkId = 28,
              Name = "Guadalupe Mountains",
              State = "Texas",
              Coordinates = "31°55'N 104°52'W / 31.92°N 104.87°W",
              Established = "15-Oct-66",
              Area = "86,415.97 acres (349.7†km2)",
              Description = "This park has Guadalupe Peak, the highest point in Texas, the scenic McKittrick Canyon full of Bigtooth Maples, part of the Chihuahuan Desert, and a fossilized reef from the Permian."
            },
            new Park
            {
              ParkId = 29,
              Name = "Haleakalā",
              State = "Hawaii",
              Coordinates = "20°43'N 156°10'W / 20.72°N 156.17°W",
              Established = "1-Aug-16",
              Area = "29,093.67 acres (117.7†km2)",
              Description = "The Haleakalā volcano on Maui has a very large crater with many cinder cones, Hosmer's Grove of alien trees, and the native Hawaiian Goose. The Kipahulu section has numerous pools with freshwater fish. This National Park has the greatest number of endangered species."
            },
            new Park
            {
              ParkId = 30,
              Name = "Hawaii Volcanoes",
              State = "Hawaii",
              Coordinates = "19°23'N 155°12'W / 19.38°N 155.20°W",
              Established = "1-Aug-16",
              Area = "323,431.38 acres (1,308.9†km2)",
              Description = "This park on the Big Island protects the K?lauea and Mauna Loa volcanoes, two of the world's most active. Diverse ecosystems of the park range from those at sea level to 13,000 feet (4,000†m)."
            },
            new Park
            {
              ParkId = 31,
              Name = "Hot Springs",
              State = "Arkansas",
              Coordinates = "34°31'N 93°03'W / 34.51°N 93.05°W",
              Established = "4-Mar-21",
              Area = "5,549.75 acres (22.5†km2)",
              Description = "The only National Park in an urban area, this smallest National Park is based around the natural hot springs that have been managed for public use. Bathhouse Row preserves 47 of these with many beneficial minerals."
            },
            new Park
            {
              ParkId = 32,
              Name = "Isle Royale",
              State = "Michigan",
              Coordinates = "48°06'N 88°33'W / 48.10°N 88.55°W",
              Established = "3-Mar-31",
              Area = "571,790.11 acres (2,314.0†km2)",
              Description = "The largest island in Lake Superior, this park is a site of isolation and wilderness. It has many shipwrecks, waterways, and hiking trails. The park also includes over 400 smaller islands in the waters up to 4.5 miles (7.2†km) from the island. There are only 20 mammal species and it is known for its wolf and moose relationship."
            },
            new Park
            {
              ParkId = 33,
              Name = "Joshua Tree",
              State = "California",
              Coordinates = "33°47'N 115°54'W / 33.79°N 115.90°W",
              Established = "31-Oct-94",
              Area = "789,745.47 acres (3,196.0†km2)",
              Description = "Covering parts of the Colorado and Mojave Deserts and the Little San Bernardino Mountains, this is the home of the Joshua tree. Across great elevation changes are sand dunes, dry lakes, rugged mountains, and granite monoliths."
            },
            new Park
            {
              ParkId = 34,
              Name = "Katmai",
              State = "Alaska",
              Coordinates = "58°30'N 155°00'W / 58.50°N 155.00°W",
              Established = "2-Dec-80",
              Area = "3,674,529.68 acres (14,870.3†km2)",
              Description = "This park on the Alaska Peninsula protects the Valley of Ten Thousand Smokes, an ash flow formed by the 1912 eruption of Novarupta, as well as Mount Katmai. Over 2,000 grizzly bears come here to catch spawning salmon."
            },
            new Park
            {
              ParkId = 35,
              Name = "Kenai Fjords",
              State = "Alaska",
              Coordinates = "59°55'N 149°39'W / 59.92°N 149.65°W",
              Established = "2-Dec-80",
              Area = "669,982.99 acres (2,711.3†km2)",
              Description = "Near Seward on the Kenai Peninsula, this park protects the Harding Icefield and at least 38 glaciers and fjords stemming from it. The only area accessible to the public by road is Exit Glacier, while the rest can only be viewed by boat tours."
            },
            new Park
            {
              ParkId = 36,
              Name = "Kings Canyon",
              State = "California",
              Coordinates = "36°48'N 118°33'W / 36.80°N 118.55°W",
              Established = "4-Mar-40",
              Area = "461,901.20 acres (1,869.2†km2)",
              Description = "Home to several Giant sequoia groves and the General Grant Tree, the world's second largest, this park also has part of the Kings River, site of the granite Kings Canyon, and San Joaquin River, as well as the Boyden Cave."
            },
            new Park
            {
              ParkId = 37,
              Name = "Kobuk Valley",
              State = "Alaska",
              Coordinates = "67°33'N 159°17'W / 67.55°N 159.28°W",
              Established = "2-Dec-80",
              Area = "1,750,716.50 acres (7,084.9†km2)",
              Description = "Kobuk Valley has 61 miles (98†km) of the Kobuk River and three regions of sand dunes. Created by glaciers, the Great Kobuk, the Little Kobuk, and the Hunt River Sand Dunes can reach 100 feet (30†m) high and 100°F (38°C), and they are the largest dunes in the arctic. Twice a year, half a million caribou migrate through the dunes and across river bluffs that contain ice age fossils."
            },
            new Park
            {
              ParkId = 38,
              Name = "Lake Clark",
              State = "Alaska",
              Coordinates = "60°58'N 153°25'W / 60.97°N 153.42°W",
              Established = "2-Dec-80",
              Area = "2,619,733.21 acres (10,601.7†km2)",
              Description = "The region around Lake Clark has four active volcanoes, including Mount Redoubt, rivers, glaciers, and waterfalls. There are temperate rainforests, a tundra plateau, and three mountain ranges."
            },
            new Park
            {
              ParkId = 39,
              Name = "Lassen Volcanic",
              State = "California",
              Coordinates = "40°29'N 121°31'W / 40.49°N 121.51°W",
              Established = "9-Aug-16",
              Area = "106,372.36 acres (430.5†km2)",
              Description = "Lassen Peak, the largest plug dome volcano in the world, is joined by all three other types of volcanoes in this park: shield, cinder dome, and composite. Other than the volcano, which last erupted in 1915, the park has hydrothermal areas, including fumaroles, boiling pools, and steaming ground, heated by molten rock under the peak."
            },
            new Park
            {
              ParkId = 40,
              Name = "Mammoth Cave",
              State = "Kentucky",
              Coordinates = "37°11'N 86°06'W / 37.18°N 86.10°W",
              Established = "1-Jul-41",
              Area = "52,830.19 acres (213.8†km2)",
              Description = "With 392 miles (631†km) of passageways mapped, Mammoth Cave is by far the world's longest cave system. Cave animals include eight bat species, Kentucky cave shrimp, Northern cavefish, and cave salamanders. Above ground, the park contains Green River (Kentucky), 70 miles of hiking trails, sinkholes, and springs."
            },
            new Park
            {
              ParkId = 41,
              Name = "Mesa Verde",
              State = "Colorado",
              Coordinates = "37°11'N 108°29'W / 37.18°N 108.49°W",
              Established = "29-Jun-06",
              Area = "52,121.93 acres (210.9†km2)",
              Description = "This area has over 4,000 archaeological sites of the Ancestral Pueblo, who lived here for 700 years. Cliff dwellings built in the 12th and 13th centuries include Cliff Palace, which has 150 rooms and 23 kivas, and the Balcony House, with passages and tunnels."
            },
            new Park
            {
              ParkId = 42,
              Name = "Mount Rainier",
              State = "Washington",
              Coordinates = "46°51'N 121°45'W / 46.85°N 121.75°W",
              Established = "3/2/1899",
              Area = "235,625.00 acres (953.5†km2)",
              Description = "Mount Rainier, an active volcano, is the most prominent peak in the Cascades, and it is covered by 26 named glaciers including Carbon Glacier and Emmons Glacier, the largest in the continental United States. The mountain is popular for climbing, and more than half of the park is covered by subalpine and alpine forests. Paradise on the south slope is one of the snowiest places in the world, and the Longmire visitor center is the start of the Wonderland Trail, which encircles the mountain."
            },
            new Park
            {
              ParkId = 43,
              Name = "North Cascades",
              State = "Washington",
              Coordinates = "48°42'N 121°12'W / 48.70°N 121.20°W",
              Established = "2-Oct-68",
              Area = "504,780.94 acres (2,042.8†km2)",
              Description = "This complex includes the two units of the National Park and the Ross Lake and Lake Chelan National Recreation Areas. There are numerous glaciers, and popular hiking and climbing areas are Cascade Pass, Mount Shuksan, Mount Triumph, and Eldorado Peak."
            },
            new Park
            {
              ParkId = 44,
              Name = "Olympic",
              State = "Washington",
              Coordinates = "47°58'N 123°30'W / 47.97°N 123.50°W",
              Established = "29-Jun-38",
              Area = "922,650.86 acres (3,733.8†km2)",
              Description = "Situated on the Olympic Peninsula, this park ranges from Pacific shoreline with tide pools to temperate rainforests to Mount Olympus. The glaciated Olympic Mountains overlook the Hoh Rain Forest and Quinault Rain Forest, the wettest area of the continental United States."
            },
            new Park
            {
              ParkId = 45,
              Name = "Petrified Forest",
              State = "Arizona",
              Coordinates = "35°04'N 109°47'W / 35.07°N 109.78°W",
              Established = "9-Dec-62",
              Area = "93,532.57 acres (378.5†km2)",
              Description = "This portion of the Chinle Formation has a great concentration of 225-million-year-old petrified wood. The surrounding region, the Painted Desert, has eroded red-hued volcanic rock called bentonite. There are also dinosaur fossils and over 350 Native American sites."
            },
            new Park
            {
              ParkId = 46,
              Name = "Pinnacles",
              State = "California",
              Coordinates = "36°29'N 121°10'W / 36.48°N 121.16°W",
              Established = "10-Jan-13",
              Area = "26,605.73 acres (107.7†km2)",
              Description = "Known for the namesake eroded leftovers of half of an extinct volcano, it is popular for its rock climbing."
            },
            new Park
            {
              ParkId = 47,
              Name = "Redwood",
              State = "California",
              Coordinates = "41°18'N 124°00'W / 41.30°N 124.00°W",
              Established = "2-Oct-68",
              Area = "112,512.05 acres (455.3†km2)",
              Description = "This park and the co-managed state parks protect almost half of all remaining Coastal Redwoods, the tallest trees on Earth. There are three large river systems in this very seismically active area, and the 37 miles (60†km) of protected coastline have tide pools and seastacks. The prairie, estuary, coast, river, and forest ecosystems have varied animal and plant species."
            },
            new Park
            {
              ParkId = 48,
              Name = "Rocky Mountain",
              State = "Colorado",
              Coordinates = "40°24'N 105°35'W / 40.40°N 105.58°W",
              Established = "26-Jan-15",
              Area = "265,828.41 acres (1,075.8†km2)",
              Description = "This section of the Rocky Mountains has ecosystems varying in elevation from the over 150 riparian lakes to Montane and subalpine forests to the alpine tundra. Large wildlife including mule deer, bighorn sheep, black bears, and cougars inhabit these igneous mountains and glacier valleys. The fourteener Longs Peak and Bear Lake are popular destinations."
            },
            new Park
            {
              ParkId = 49,
              Name = "Saguaro",
              State = "Arizona",
              Coordinates = "32°15'N 110°30'W / 32.25°N 110.50°W",
              Established = "14-Oct-94",
              Area = "91,439.71 acres (370.0†km2)",
              Description = "Split into the separate Rincon Mountain and Tucson Mountain Districts, the dry Sonoran Desert is still home to much life in six biotic communities. Beyond the namesake Giant Saguaro cacti, there are barrel cacti, cholla cacti, and prickly pears, as well as Lesser Long-nosed Bats, Spotted Owls, and javelinas."
            },
            new Park
            {
              ParkId = 50,
              Name = "Sequoia",
              State = "California",
              Coordinates = "36°26'N 118°41'W / 36.43°N 118.68°W",
              Established = "9/25/1890",
              Area = "404,051.17 acres (1,635.1†km2)",
              Description = "This park protects the Giant Forest, which has the world's largest tree, General Sherman, as well as four of the next nine. It also has over 240 caves, the tallest mountain in the continental U.S., Mount Whitney, and the granite dome Moro Rock."
            },
            new Park
            {
              ParkId = 51,
              Name = "Shenandoah",
              State = "Virginia",
              Coordinates = "38°32'N 78°21'W / 38.53°N 78.35°W",
              Established = "5/22/2026",
              Area = "199,045.23 acres (805.5†km2)",
              Description = "Shenandoah's Blue Ridge Mountains are covered by hardwood forests that are home to tens of thousands of animals. The Skyline Drive and Appalachian Trail run the entire length of this narrow park that has more than 500 miles (800†km) of hiking trails along scenic overlooks and waterfalls of the Shenandoah River."
            },
            new Park
            {
              ParkId = 52,
              Name = "Theodore Roosevelt",
              State = "North Dakota",
              Coordinates = "46°58'N 103°27'W / 46.97°N 103.45°W",
              Established = "10-Nov-78",
              Area = "70,446.89 acres (285.1†km2)",
              Description = "This region that enticed and influenced President Theodore Roosevelt is now a park of three units in the badlands. Besides Roosevelt's historic cabin, there are scenic drives and backcountry hiking opportunities. Wildlife includes American Bison, pronghorns, Bighorn sheep, and wild horses."
            },
            new Park
            {
              ParkId = 53,
              Name = "Virgin Islands",
              State = "United States Virgin Islands",
              Coordinates = "18°20'N 64°44'W / 18.33°N 64.73°W",
              Established = "2-Aug-56",
              Area = "14,688.87 acres (59.4†km2)",
              Description = "The island of Saint John has rich human and natural history. There are Taino archaeological sites and ruins of sugar plantations from Columbus's time. Past the pristine beaches are mangroves, seagrass beds, coral reefs and algal plains."
            },
            new Park
            {
              ParkId = 54,
              Name = "Voyageurs",
              State = "Minnesota",
              Coordinates = "48°30'N 92°53'W / 48.50°N 92.88°W",
              Established = "8-Jan-71",
              Area = "218,200.17 acres (883.0†km2)",
              Description = "This park on four main lakes, a site for canoeing, kayaking, and fishing, has a history of Ojibwe Native Americans, French fur traders called voyageurs, and a gold rush. Formed by glaciers, this region has tall bluffs, rock gardens, islands and bays, and historic buildings."
            },
            new Park
            {
              ParkId = 55,
              Name = "Wind Cave",
              State = "South Dakota",
              Coordinates = "43°34'N 103°29'W / 43.57°N 103.48°W",
              Established = "9-Jan-03",
              Area = "28,295.03 acres (114.5†km2)",
              Description = "Wind Cave is distinctive for its calcite fin formations called boxwork and needle-like growths called frostwork. The cave, which was discovered by the sound of wind coming from a hole in the ground, is the world's densest cave system. Above ground is a mixed-grass prairie with animals such as bison, black-footed ferrets, and prairie dogs, and Ponderosa pine forests home to cougars and elk."
            },
            new Park
            {
              ParkId = 56,
              Name = "Wrangell –St. Elias",
              State = "Alaska",
              Coordinates = "61°00'N 142°00'W / 61.00°N 142.00°W",
              Established = "2-Dec-80",
              Area = "8,323,147.59 acres (33,682.6†km2)",
              Description = "This mountainous land has the convergence of the Alaska, Chugach, and Wrangell-Saint Elias Ranges, which have many of the continent's tallest mountains over 16,000 feet (4,900†m), including Mount Saint Elias. More than 25% of this park of volcanic peaks is covered with glaciers, including the tidewater Hubbard Glacier, piedmont Malaspina Glacier, and valley Nabesna Glacier."
            },
            new Park
            {
              ParkId = 57,
              Name = "Yellowstone",
              State = "Wyoming, Montana, Idaho",
              Coordinates = "44°36'N 110°30'W / 44.60°N 110.50°W",
              Established = "3/1/1872",
              Area = "2,219,790.71 acres (8,983.2†km2)",
              Description = "Situated on the Yellowstone Caldera, the first national park in the world has vast geothermal areas such as hot springs and geysers, the best-known being Old Faithful and Grand Prismatic Spring. The yellow-hued Grand Canyon of the Yellowstone River has numerous waterfalls, and four mountain ranges run through the park. There are almost 60 mammal species, including the gray wolf, grizzly bear, lynx, bison, and elk."
            },
            new Park
            {
              ParkId = 58,
              Name = "Yosemite",
              State = "California",
              Coordinates = "37°50'N 119°30'W / 37.83°N 119.50°W",
              Established = "10/1/1890",
              Area = "761,266.19 acres (3,080.7†km2)",
              Description = "Yosemite has towering cliffs, waterfalls, and sequoias in a diverse area of geology and hydrology. Half Dome and El Capitan rise from the central glacier-formed Yosemite Valley, as does Yosemite Falls, North America's tallest waterfall. Three Giant Sequoia groves and vast wilderness are home to diverse wildlife."
            },
            new Park
            {
              ParkId = 59,
              Name = "Zion",
              State = "Utah",
              Coordinates = "37°18'N 113°03'W / 37.30°N 113.05°W",
              Established = "19-Nov-19",
              Area = "146,597.60 acres (593.3†km2)",
              Description = "This geologically unique area has colorful sandstone canyons, high plateaus, and rock towers. Natural arches and exposed formations of the Colorado Plateau make up a large wilderness of four ecosystems."
            },
            new Park
            {
              ParkId = 60,
              Name = "Sleeping Bear Dunes",
              State = "Michigan",
              Coordinates = "44.87'N, 86.05'W / 44.87° N, 86.05° W",
              Established = "1-Oct-70",
              Area = "71,199.40 acres (288.13 km2)",
              Description = "Large complex of shifting sand dunes, extending 7 miles (11 km) along the northeastern shore of Lake Michigan between Empire and Glen Haven, in the northwestern part of the Lower Peninsula of Michigan, U.S. The name derives from an Ojibwa Indian legend in which a mother bear and two cubs swam across the lake from Wisconsin to escape a forest fire; the cubs drowned and became the North and South Manitou islands, and the spot where the mother bear waited became Sleeping Bear Dune. The dunes rise as high as 460 feet (140 metres) above the lake and cover 4 square miles (10 square km)."
            }
        );
    }

    public DbSet<Park> Parks { get; set; }
  }
}