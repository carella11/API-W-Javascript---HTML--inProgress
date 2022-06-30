async function getSongs() {
    let respone = await axios.get('/songs');
    model.songs = response.data;
    updateView;
}


function addSong() {
    const selectedSong = model.people.find(p=>p.id===model.app.selectedSong);
    const newSong = { ...model.inputs.addPage.songs };
    newSong.id = 1 + Math.max(...model.songs.map(p => p.id));
    model.inputs.addPage.addRelationshopFunction(newSong, selectedSong);
    model.app.page = 'single';
    model.app.selectedSong = newSong.id;
    model.songs.push(newSong);
    updateView();
}