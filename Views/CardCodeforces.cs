namespace MyUhuntCard.Views
{
    public class CardCodeforces
    {
        public string Svg = @"<svg xmlns='http://www.w3.org/2000/svg' width='469' height='192' viewBox='0 0 467 195' fill='none' role='img' aria-labelledby='descId'> <style>
        @keyframes fadeInAnimation 
        {
            from 
            {
                opacity: 0;
            }
            to 
            {
                opacity: 1;
            }
        }

        @keyframes blink
        {
            50% {opacity: 1%; }
        }

        .header 
        {
            margin: 0;
            position: absolute;
            top: 20px;
            left: 30px;   
            font-size: 16px;
            color: white;
            fill: #fff;
            font-weight: 700;
            font-family: system-ui, -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
            animation: fadeInAnimation 0.6s ease-in-out forwards;
        }

        .number 
        {
            position: absolute;
            top: 60px;
            fill: #fff;
            left: 170px;   
            font-size: 84px;
            color: #79FF97;
            font-weight: 700;
            font-family: system-ui, -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
            animation: fadeInAnimation 0.6s ease-in-out forwards;
        }

        .logo
        {
            top: 64px;
            left: 310px;
            position: absolute;
            animation: fadeInAnimation 2.5s ease-in-out forwards;
        }

        .terminal
        {
            top: 80px;
            left: 50px;
            position: absolute;
            animation: blink 1s ease-in-out infinite;
        }

    </style>";

        public string GetCard(string Username, string Accepted)
        {
            Svg += $@"
    <svg class='box' width='467' height='195' viewBox='0 0 467 195' fill='none' xmlns='http://www.w3.org/2000/svg'>
        <rect width='467' height='195' rx='8' fill='#151515'/>
    </svg>
    
    
    
    <svg class='logo' y='60' x='300' width='118' height='118' viewBox='0 0 118 118' fill='none' xmlns='http://www.w3.org/2000/svg' xmlns:xlink='http://www.w3.org/1999/xlink'>
<rect x='4' y='4' width='110' height='110' rx='55' fill='url(#pattern0_9_3)'/>
<rect x='2' y='2' width='114' height='114' rx='57' stroke='white' stroke-opacity='0.79' stroke-width='4'/>
<defs>
<pattern id='pattern0_9_3' patternContentUnits='objectBoundingBox' width='1' height='1'>
<use xlink:href='#image0_9_3' transform='scale(0.00512821)'/>
</pattern>
<image id='image0_9_3' width='195' height='195' xlink:href='data:image/png;base64,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'/>
</defs>
</svg>

    <svg class='terminal' y='80' x='50' width='80' height='80' viewBox='0 0 67 58' fill='none' xmlns='http://www.w3.org/2000/svg'>
        <path d='M64.32 0H2.68C1.19762 0 0 1.03675 0 2.32V55.68C0 56.9632 1.19762 58 2.68 58H64.32C65.8024 58 67 56.9632 67 55.68V2.32C67 1.03675 65.8024 0 64.32 0ZM33.5921 29.4422L17.5121 41.1147C17.0766 41.4337 16.415 41.1655 16.415 40.6725V36.1267C16.415 35.96 16.5071 35.7932 16.6579 35.6845L24.7409 29.8089C25.2902 29.4095 25.2902 28.5905 24.7409 28.1911L16.6579 22.3155C16.5809 22.2629 16.5189 22.1956 16.4768 22.1189C16.4347 22.0422 16.4136 21.9582 16.415 21.8733V17.3275C16.415 16.8345 17.0766 16.5662 17.5121 16.8852L33.5921 28.5505C33.9187 28.7825 33.9187 29.2102 33.5921 29.4422ZM50.585 40.6725C50.585 40.9915 50.3003 41.2525 49.9569 41.2525H34.4631C34.1198 41.2525 33.835 40.9915 33.835 40.6725V37.1925C33.835 36.8735 34.1198 36.6125 34.4631 36.6125H49.9569C50.3003 36.6125 50.585 36.8735 50.585 37.1925V40.6725Z' fill='#79FF97'/>
    </svg>
        
    <g xmlns='http://www.w3.org/2000/svg' data-testid='card-title' transform='translate(25, 35)'>
        <g transform='translate(0, 0)'>
            <text x='145' y='115' class='number' data-testid='number'>{Accepted}</text>
        </g>
    </g> 
    <g xmlns='http://www.w3.org/2000/svg' data-testid='card-title' transform='translate(25, 35)'>
        <g transform='translate(0, 0)'>
            <text x='0' y='0' class='header' data-testid='header'>Accepted codes by {Username} on Codeforces</text>
        </g>
    </g>    
</svg>";
            return Svg.Trim();
        }
    }
}
