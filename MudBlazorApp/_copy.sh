date=`date +"%H.%M"`
name="CSharp"

target="$HOME/Téléchargements/Copies/CP-$name-$date"

if [ ! -d $target ]; then
    mkdir $target

    cp -r Client $target
    cp -r Server $target

    cp *.cs* $target
    cp *.js* $target
fi

echo "Copie $name - $date"