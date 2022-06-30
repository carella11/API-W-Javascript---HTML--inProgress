function updateViewList() {
    document.getElementById('app').innerHTML =
       // model.songs.map(p =>/*html*/
            `

        <li>
            ${p.songName || ''} 
            ${p.artist || ' '} 
        </li>
    `).join('');
}