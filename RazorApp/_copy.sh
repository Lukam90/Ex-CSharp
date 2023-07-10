date=`date +"%H.%M"`
name="Razor"

target="$HOME/Téléchargements/Copies/CP-$name-$date"

if [ ! -d $target ]; then
    mkdir $target

    cp *.cs* $target
    cp *.js* $target

    #cp -r Controllers $target
    cp -r Data $target
    cp -r Migrations $target
    cp -r Models $target
    cp -r Pages $target
    cp -r Properties $target
    cp -r wwwroot $target
fi

echo "Copie $name - $date"