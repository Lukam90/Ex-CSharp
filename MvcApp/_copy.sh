date=`date +"%H.%M"`
name="MVC"

target="$HOME/Téléchargements/Copies/CP-$name-$date"

if [ ! -d $target ]; then
    mkdir $target

    cp $back/*.cs* $target
    cp $back/*.js* $target

    cp -r $back/Controllers $target
    #cp -r $back/Data $target
    #cp -r $back/Migrations $target
    cp -r $back/Models $target
    cp -r $back/Properties $target
    cp -r $back/Views $target
    cp -r $back/wwwroot $target
fi

echo "Copie $name - $date"