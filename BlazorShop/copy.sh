date=`date +"%H.%M"`
name="Blazor"

target="$HOME/Téléchargements/Copies/CP-$name-$date"

if [ ! -d $target ]; then
    mkdir $target

    cp *.cs* $target
    cp *.js* $target
    cp *.razor $target

    cp -r Data $target
    cp -r Models $target
    cp -r Pages $target
    cp -r Properties $target
    cp -r Shared $target
    cp -r wwwroot $target
fi

echo "Copie $name - $date"