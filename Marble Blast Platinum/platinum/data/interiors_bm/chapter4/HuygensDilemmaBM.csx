<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2024/09/25 21:46:30">
    <Sunlight azimuth="180" elevation="35" color="255 255 255" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="0" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="8" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="1">
                    <Entity id="0" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32" light_geometry_scale="8" light_smoothing_scale="4.0" light_mesh_scale="1.0" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="487">
                    <Brush id="0" owner="0" type="0" pos="0 0 0.25" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 0 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 0.25" />
                            <Vertex pos="6 2 -0.25" />
                            <Vertex pos="6 -2 0.25" />
                            <Vertex pos="6 -2 -0.25" />
                            <Vertex pos="-6 2 0.25" />
                            <Vertex pos="-6 2 -0.25" />
                            <Vertex pos="-6 -2 0.25" />
                            <Vertex pos="-6 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_C" texgens="1 0 0 -512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="1" owner="0" type="0" pos="0 -2.125 0.25" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -2.125 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.125 0.25" />
                            <Vertex pos="6 0.125 -0.25" />
                            <Vertex pos="6 -0.125 0.25" />
                            <Vertex pos="6 -0.125 -0.25" />
                            <Vertex pos="-6 0.125 0.25" />
                            <Vertex pos="-6 0.125 -0.25" />
                            <Vertex pos="-6 -0.125 0.25" />
                            <Vertex pos="-6 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white_doublevert" texgens="0 1 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 -512 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 640 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="2" owner="0" type="0" pos="6.125 0 0.25" rot="1 0 0 0" scale="" transform="1 0 0 6.125 0 1 0 0 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 2 0.25" />
                            <Vertex pos="0.125 2 -0.25" />
                            <Vertex pos="0.125 -2 0.25" />
                            <Vertex pos="0.125 -2 -0.25" />
                            <Vertex pos="-0.125 2 0.25" />
                            <Vertex pos="-0.125 2 -0.25" />
                            <Vertex pos="-0.125 -2 0.25" />
                            <Vertex pos="-0.125 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white" texgens="0 1 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white" texgens="0 -1 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublevert" texgens="1 0 0 32 0 -1 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 -1 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="3" owner="0" type="0" pos="0 2.125 0.25" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 2.125 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.125 0.25" />
                            <Vertex pos="6 0.125 -0.25" />
                            <Vertex pos="6 -0.125 0.25" />
                            <Vertex pos="6 -0.125 -0.25" />
                            <Vertex pos="-6 0.125 0.25" />
                            <Vertex pos="-6 0.125 -0.25" />
                            <Vertex pos="-6 -0.125 0.25" />
                            <Vertex pos="-6 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white_doublevert" texgens="0 1 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -288 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 -512 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 640 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="4" owner="0" type="0" pos="6.125 2.125 0.25" rot="1 0 0 0" scale="" transform="1 0 0 6.125 0 1 0 2.125 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.125 0.25" />
                            <Vertex pos="0.125 0.125 -0.25" />
                            <Vertex pos="0.125 -0.125 0.25" />
                            <Vertex pos="0.125 -0.125 -0.25" />
                            <Vertex pos="-0.125 0.125 0.25" />
                            <Vertex pos="-0.125 0.125 -0.25" />
                            <Vertex pos="-0.125 -0.125 0.25" />
                            <Vertex pos="-0.125 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white_doublevert" texgens="0 1 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -288 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_half" texgens="1 0 0 32 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="64 64">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_half" texgens="-1 0 0 96 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="64 64">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="5" owner="0" type="0" pos="6.125 -2.125 0.25" rot="1 0 0 0" scale="" transform="1 0 0 6.125 0 1 0 -2.125 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.125 0.25" />
                            <Vertex pos="0.125 0.125 -0.25" />
                            <Vertex pos="0.125 -0.125 0.25" />
                            <Vertex pos="0.125 -0.125 -0.25" />
                            <Vertex pos="-0.125 0.125 0.25" />
                            <Vertex pos="-0.125 0.125 -0.25" />
                            <Vertex pos="-0.125 -0.125 0.25" />
                            <Vertex pos="-0.125 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white_doublevert" texgens="0 1 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -288 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_half" texgens="1 0 0 32 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="64 64">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_half" texgens="-1 0 0 96 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="64 64">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="6" owner="0" type="0" pos="-14 0 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 0 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 0.25" />
                            <Vertex pos="4 2 -0.25" />
                            <Vertex pos="4 -2 0.25" />
                            <Vertex pos="4 -2 -0.25" />
                            <Vertex pos="-4 2 0.25" />
                            <Vertex pos="-4 2 -0.25" />
                            <Vertex pos="-4 -2 0.25" />
                            <Vertex pos="-4 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_C" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="7" owner="0" type="0" pos="-14 -2.125 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 -2.125 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.125 0.25" />
                            <Vertex pos="4 0.125 -0.25" />
                            <Vertex pos="4 -0.125 0.25" />
                            <Vertex pos="4 -0.125 -0.25" />
                            <Vertex pos="-4 0.125 0.25" />
                            <Vertex pos="-4 0.125 -0.25" />
                            <Vertex pos="-4 -0.125 0.25" />
                            <Vertex pos="-4 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white_doublevert" texgens="0 1 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 0 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 128 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="8" owner="0" type="0" pos="-14 2.125 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 2.125 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.125 0.25" />
                            <Vertex pos="4 0.125 -0.25" />
                            <Vertex pos="4 -0.125 0.25" />
                            <Vertex pos="4 -0.125 -0.25" />
                            <Vertex pos="-4 0.125 0.25" />
                            <Vertex pos="-4 0.125 -0.25" />
                            <Vertex pos="-4 -0.125 0.25" />
                            <Vertex pos="-4 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white_doublevert" texgens="0 1 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -288 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 0 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 128 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="9" owner="0" type="0" pos="-26 0 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -26 0 1 0 0 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 0.25" />
                            <Vertex pos="4 2 -0.25" />
                            <Vertex pos="4 -2 0.25" />
                            <Vertex pos="4 -2 -0.25" />
                            <Vertex pos="-8 2 0.25" />
                            <Vertex pos="-8 2 -0.25" />
                            <Vertex pos="-8 -2 0.25" />
                            <Vertex pos="-8 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="Blasted" material="bm_trim" texgens="0 -1 0 0 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_C" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="10" owner="0" type="0" pos="-26 -2.125 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -26 0 1 0 -2.125 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.125 0.25" />
                            <Vertex pos="4 0.125 -0.25" />
                            <Vertex pos="4 -0.125 0.25" />
                            <Vertex pos="4 -0.125 -0.25" />
                            <Vertex pos="-8 0.125 0.25" />
                            <Vertex pos="-8 0.125 -0.25" />
                            <Vertex pos="-8 -0.125 0.25" />
                            <Vertex pos="-8 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white_doublevert" texgens="0 1 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 0 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 128 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="11" owner="0" type="0" pos="-26 2.125 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -26 0 1 0 2.125 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.125 0.25" />
                            <Vertex pos="4 0.125 -0.25" />
                            <Vertex pos="4 -0.125 0.25" />
                            <Vertex pos="4 -0.125 -0.25" />
                            <Vertex pos="-8 0.125 0.25" />
                            <Vertex pos="-8 0.125 -0.25" />
                            <Vertex pos="-8 -0.125 0.25" />
                            <Vertex pos="-8 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white_doublevert" texgens="0 1 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -288 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 0 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 128 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="12" owner="0" type="0" pos="-37 -1 0.75" rot="1 0 0 0" scale="" transform="1 0 0 -37 0 1 0 -1 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 1 0.25" />
                            <Vertex pos="3 1 -0.25" />
                            <Vertex pos="3 -1 0.25" />
                            <Vertex pos="3 -1 -0.25" />
                            <Vertex pos="-3 1 0.25" />
                            <Vertex pos="-3 1 -0.25" />
                            <Vertex pos="-3 -1 0.25" />
                            <Vertex pos="-3 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_trim" texgens="0 1 0 -256 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_C" texgens="1 0 0 256 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="13" owner="0" type="0" pos="-37 -2.125 0.75" rot="1 0 0 0" scale="" transform="1 0 0 -37 0 1 0 -2.125 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.125 0.25" />
                            <Vertex pos="3 0.125 -0.25" />
                            <Vertex pos="3 -0.125 0.25" />
                            <Vertex pos="3 -0.125 -0.25" />
                            <Vertex pos="-3 0.125 0.25" />
                            <Vertex pos="-3 0.125 -0.25" />
                            <Vertex pos="-3 -0.125 0.25" />
                            <Vertex pos="-3 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white_doublevert" texgens="0 1 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 256 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 -128 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="14" owner="0" type="0" pos="-37 0.125 0.75" rot="1 0 0 0" scale="" transform="1 0 0 -37 0 1 0 0.125 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.125 0.25" />
                            <Vertex pos="3 0.125 -0.25" />
                            <Vertex pos="3 -0.125 0.25" />
                            <Vertex pos="3 -0.125 -0.25" />
                            <Vertex pos="-3 0.125 0.25" />
                            <Vertex pos="-3 0.125 -0.25" />
                            <Vertex pos="-3 -0.125 0.25" />
                            <Vertex pos="-3 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white_doublevert" texgens="0 1 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -288 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 256 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 -128 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="15" owner="0" type="0" pos="-51 -19 0.75" rot="1 0 0 0" scale="" transform="1 0 0 -51 0 1 0 -19 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 7 0.25" />
                            <Vertex pos="1 7 -0.25" />
                            <Vertex pos="1 -9 0.25" />
                            <Vertex pos="1 -9 -0.25" />
                            <Vertex pos="-1 7 0.25" />
                            <Vertex pos="-1 7 -0.25" />
                            <Vertex pos="-1 -9 0.25" />
                            <Vertex pos="-1 -9 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -7" album="" material="bm_edge_white" texgens="-1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -9" album="Blasted" material="bm_trim" texgens="1 0 0 -13056 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_C" texgens="1 0 0 768 0 -1 0 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 -128 0 -1 0 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="16" owner="0" type="0" pos="-49.875 -19 0.75" rot="1 0 0 0" scale="" transform="1 0 0 -49.875 0 1 0 -19 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 7 0.25" />
                            <Vertex pos="0.125 7 -0.25" />
                            <Vertex pos="0.125 -9 0.25" />
                            <Vertex pos="0.125 -9 -0.25" />
                            <Vertex pos="-0.125 7 0.25" />
                            <Vertex pos="-0.125 7 -0.25" />
                            <Vertex pos="-0.125 -9 0.25" />
                            <Vertex pos="-0.125 -9 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white" texgens="0 1 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white" texgens="0 -1 0 -1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -7" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -9" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublevert" texgens="1 0 0 32 0 -1 0 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 -1 0 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="17" owner="0" type="0" pos="-52.125 -19 0.75" rot="1 0 0 0" scale="" transform="1 0 0 -52.125 0 1 0 -19 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 7 0.25" />
                            <Vertex pos="0.125 7 -0.25" />
                            <Vertex pos="0.125 -9 0.25" />
                            <Vertex pos="0.125 -9 -0.25" />
                            <Vertex pos="-0.125 7 0.25" />
                            <Vertex pos="-0.125 7 -0.25" />
                            <Vertex pos="-0.125 -9 0.25" />
                            <Vertex pos="-0.125 -9 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white" texgens="0 1 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white" texgens="0 -1 0 -1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -7" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -9" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublevert" texgens="1 0 0 32 0 -1 0 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 -1 0 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="18" owner="0" type="0" pos="-52 -32 1.25" rot="1 0 0 0" scale="" transform="1 0 0 -52 0 1 0 -32 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 0.25" />
                            <Vertex pos="2 4 -0.25" />
                            <Vertex pos="2 -4 0.25" />
                            <Vertex pos="2 -4 -0.25" />
                            <Vertex pos="-2 4 0.25" />
                            <Vertex pos="-2 4 -0.25" />
                            <Vertex pos="-2 -4 0.25" />
                            <Vertex pos="-2 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_trim" texgens="-1 0 0 13312 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_C" texgens="1 0 0 512 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="19" owner="0" type="0" pos="-49.875 -32 1.25" rot="1 0 0 0" scale="" transform="1 0 0 -49.875 0 1 0 -32 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 4 0.25" />
                            <Vertex pos="0.125 4 -0.25" />
                            <Vertex pos="0.125 -4 0.25" />
                            <Vertex pos="0.125 -4 -0.25" />
                            <Vertex pos="-0.125 4 0.25" />
                            <Vertex pos="-0.125 4 -0.25" />
                            <Vertex pos="-0.125 -4 0.25" />
                            <Vertex pos="-0.125 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white" texgens="0 1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white" texgens="0 -1 0 -1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublevert" texgens="1 0 0 32 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="20" owner="0" type="0" pos="-54.125 -32 1.25" rot="1 0 0 0" scale="" transform="1 0 0 -54.125 0 1 0 -32 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 4 0.25" />
                            <Vertex pos="0.125 4 -0.25" />
                            <Vertex pos="0.125 -4 0.25" />
                            <Vertex pos="0.125 -4 -0.25" />
                            <Vertex pos="-0.125 4 0.25" />
                            <Vertex pos="-0.125 4 -0.25" />
                            <Vertex pos="-0.125 -4 0.25" />
                            <Vertex pos="-0.125 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white" texgens="0 1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white" texgens="0 -1 0 -1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublevert" texgens="1 0 0 32 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="25" owner="0" type="0" pos="-52 -93 2.75" rot="1 0 0 0" scale="" transform="1 0 0 -52 0 1 0 -93 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 0.25" />
                            <Vertex pos="2 4 -0.25" />
                            <Vertex pos="2 -4 0.25" />
                            <Vertex pos="2 -4 -0.25" />
                            <Vertex pos="-2 4 0.25" />
                            <Vertex pos="-2 4 -0.25" />
                            <Vertex pos="-2 -4 0.25" />
                            <Vertex pos="-2 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_C" texgens="1 0 0 512 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="26" owner="0" type="0" pos="-49.875 -93 2.75" rot="1 0 0 0" scale="" transform="1 0 0 -49.875 0 1 0 -93 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 4 0.25" />
                            <Vertex pos="0.125 4 -0.25" />
                            <Vertex pos="0.125 -4 0.25" />
                            <Vertex pos="0.125 -4 -0.25" />
                            <Vertex pos="-0.125 4 0.25" />
                            <Vertex pos="-0.125 4 -0.25" />
                            <Vertex pos="-0.125 -4 0.25" />
                            <Vertex pos="-0.125 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white" texgens="0 1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white" texgens="0 -1 0 -1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublevert" texgens="1 0 0 32 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="27" owner="0" type="0" pos="-54.125 -93 2.75" rot="1 0 0 0" scale="" transform="1 0 0 -54.125 0 1 0 -93 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 4 0.25" />
                            <Vertex pos="0.125 4 -0.25" />
                            <Vertex pos="0.125 -4 0.25" />
                            <Vertex pos="0.125 -4 -0.25" />
                            <Vertex pos="-0.125 4 0.25" />
                            <Vertex pos="-0.125 4 -0.25" />
                            <Vertex pos="-0.125 -4 0.25" />
                            <Vertex pos="-0.125 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white" texgens="0 1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white" texgens="0 -1 0 -1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublevert" texgens="1 0 0 32 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="28" owner="0" type="0" pos="-52 -95 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -52 0 1 0 -95 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 0.25" />
                            <Vertex pos="2 4 -0.25" />
                            <Vertex pos="2 -4 0.25" />
                            <Vertex pos="2 -4 -0.25" />
                            <Vertex pos="-2 4 0.25" />
                            <Vertex pos="-2 4 -0.25" />
                            <Vertex pos="-2 -4 0.25" />
                            <Vertex pos="-2 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_friction_sand" texgens="1 0 0 -13312 0 -1 0 24320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="29" owner="0" type="0" pos="-49.875 -97 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -49.875 0 1 0 -97 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 2 0.25" />
                            <Vertex pos="0.125 2 -0.25" />
                            <Vertex pos="0.125 -2 0.25" />
                            <Vertex pos="0.125 -2 -0.25" />
                            <Vertex pos="-0.125 2 0.25" />
                            <Vertex pos="-0.125 2 -0.25" />
                            <Vertex pos="-0.125 -2 0.25" />
                            <Vertex pos="-0.125 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white" texgens="0 1 0 1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white" texgens="0 -1 0 -1280 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublevert" texgens="1 0 0 32 0 -1 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 -1 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="30" owner="0" type="0" pos="-54.125 -94.75 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -54.125 0 1 0 -94.75 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 4.25 0.25" />
                            <Vertex pos="0.125 4.25 -0.25" />
                            <Vertex pos="0.125 -4.25 0.25" />
                            <Vertex pos="0.125 -4.25 -0.25" />
                            <Vertex pos="-0.125 4.25 0.25" />
                            <Vertex pos="-0.125 4.25 -0.25" />
                            <Vertex pos="-0.125 -4.25 0.25" />
                            <Vertex pos="-0.125 -4.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white" texgens="0 1 0 1600 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white" texgens="0 -1 0 -1856 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4.25" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4.25" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublevert" texgens="1 0 0 32 0 -1 0 -1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 -1 0 -1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="31" owner="0" type="0" pos="-49.875 -90.75 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -49.875 0 1 0 -90.75 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.25 0.25" />
                            <Vertex pos="0.125 0.25 -0.25" />
                            <Vertex pos="0.125 -0.25 0.25" />
                            <Vertex pos="0.125 -0.25 -0.25" />
                            <Vertex pos="-0.125 0.25 0.25" />
                            <Vertex pos="-0.125 0.25 -0.25" />
                            <Vertex pos="-0.125 -0.25 0.25" />
                            <Vertex pos="-0.125 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white" texgens="0 1 0 576 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white" texgens="0 -1 0 -832 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublevert" texgens="1 0 0 32 0 -1 0 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 -1 0 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="32" owner="0" type="0" pos="-52 -90.75 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -52 0 1 0 -90.75 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.25" />
                            <Vertex pos="2 0.25 -0.25" />
                            <Vertex pos="2 -0.25 0.25" />
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="-2 0.25 0.25" />
                            <Vertex pos="-2 0.25 -0.25" />
                            <Vertex pos="-2 -0.25 0.25" />
                            <Vertex pos="-2 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 576 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -832 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 512 0 -1 0 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 -1 0 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="177" owner="0" type="0" pos="-42 -93 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -42 0 1 0 -93 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 0.25" />
                            <Vertex pos="6 2 -0.25" />
                            <Vertex pos="6 -2 0.25" />
                            <Vertex pos="6 -2 -0.25" />
                            <Vertex pos="-6 2 0.25" />
                            <Vertex pos="-6 2 -0.25" />
                            <Vertex pos="-6 -2 0.25" />
                            <Vertex pos="-6 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_C" texgens="1 0 0 1536 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 -512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="178" owner="0" type="0" pos="-42 -95.125 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -42 0 1 0 -95.125 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.125 0.25" />
                            <Vertex pos="6 0.125 -0.25" />
                            <Vertex pos="6 -0.125 0.25" />
                            <Vertex pos="6 -0.125 -0.25" />
                            <Vertex pos="-6 0.125 0.25" />
                            <Vertex pos="-6 0.125 -0.25" />
                            <Vertex pos="-6 -0.125 0.25" />
                            <Vertex pos="-6 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white_doublevert" texgens="0 1 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 -512 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 640 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="179" owner="0" type="0" pos="-42 -90.875 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -42 0 1 0 -90.875 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.125 0.25" />
                            <Vertex pos="6 0.125 -0.25" />
                            <Vertex pos="6 -0.125 0.25" />
                            <Vertex pos="6 -0.125 -0.25" />
                            <Vertex pos="-6 0.125 0.25" />
                            <Vertex pos="-6 0.125 -0.25" />
                            <Vertex pos="-6 -0.125 0.25" />
                            <Vertex pos="-6 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white_doublevert" texgens="0 1 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -288 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 -512 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 640 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="180" owner="0" type="0" pos="-30 -101 14.75" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 -101 0 0 1 14.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_C" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="181" owner="0" type="0" pos="-30 -103.125 14.75" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 -103.125 0 0 1 14.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 0.25" />
                            <Vertex pos="2 0.125 -0.25" />
                            <Vertex pos="2 -0.125 0.25" />
                            <Vertex pos="2 -0.125 -0.25" />
                            <Vertex pos="-2 0.125 0.25" />
                            <Vertex pos="-2 0.125 -0.25" />
                            <Vertex pos="-2 -0.125 0.25" />
                            <Vertex pos="-2 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 1 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 -1536 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 1664 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="182" owner="0" type="0" pos="-30 -98.875 14.75" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 -98.875 0 0 1 14.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 0.25" />
                            <Vertex pos="2 0.125 -0.25" />
                            <Vertex pos="2 -0.125 0.25" />
                            <Vertex pos="2 -0.125 -0.25" />
                            <Vertex pos="-2 0.125 0.25" />
                            <Vertex pos="-2 0.125 -0.25" />
                            <Vertex pos="-2 -0.125 0.25" />
                            <Vertex pos="-2 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 1 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -288 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 -1536 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 1664 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="183" owner="0" type="0" pos="-26 -101 15.25" rot="1 0 0 0" scale="" transform="1 0 0 -26 0 1 0 -101 0 0 1 15.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1.99999 0.749999" />
                            <Vertex pos="2 1.99999 0.250001" />
                            <Vertex pos="2 -2 0.749999" />
                            <Vertex pos="2 -2 0.250001" />
                            <Vertex pos="-2 1.99999 -0.250001" />
                            <Vertex pos="-2 1.99999 -0.749999" />
                            <Vertex pos="-2 -2 -0.250001" />
                            <Vertex pos="-2 -2 -0.749999" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1.99999" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -0.242535" album="" material="bm_tile03_C" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.242535" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="184" owner="0" type="0" pos="-26 -103.125 15.25" rot="1 0 0 0" scale="" transform="1 0 0 -26 0 1 0 -103.125 0 0 1 15.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 0.749999" />
                            <Vertex pos="2 0.125 0.250001" />
                            <Vertex pos="2 -0.125 0.749999" />
                            <Vertex pos="2 -0.125 0.250001" />
                            <Vertex pos="-2 0.125 -0.250001" />
                            <Vertex pos="-2 0.125 -0.749999" />
                            <Vertex pos="-2 -0.125 -0.250001" />
                            <Vertex pos="-2 -0.125 -0.749999" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 1 0 96 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -352 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 1664 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -384 0.25 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -0.242535" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 -1536 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.242535" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 1664 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="185" owner="0" type="0" pos="-26 -98.875 15.25" rot="1 0 0 0" scale="" transform="1 0 0 -26 0 1 0 -98.875 0 0 1 15.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 0.749999" />
                            <Vertex pos="2 0.125 0.250001" />
                            <Vertex pos="2 -0.125008 0.749999" />
                            <Vertex pos="2 -0.125008 0.250001" />
                            <Vertex pos="-2 0.125 -0.250001" />
                            <Vertex pos="-2 0.125 -0.749999" />
                            <Vertex pos="-2 -0.125008 -0.250001" />
                            <Vertex pos="-2 -0.125008 -0.749999" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 1 0 32 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -288 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 -384 0.25 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125008" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970142 -0.242535" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 -1536 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970142 -0.242535" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 1664 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="186" owner="0" type="0" pos="-22 -101 15.75" rot="1 0 0 0" scale="" transform="1 0 0 -22 0 1 0 -101 0 0 1 15.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_C" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="187" owner="0" type="0" pos="-22 -103.125 15.75" rot="1 0 0 0" scale="" transform="1 0 0 -22 0 1 0 -103.125 0 0 1 15.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 0.25" />
                            <Vertex pos="2 0.125 -0.25" />
                            <Vertex pos="2 -0.125 0.25" />
                            <Vertex pos="2 -0.125 -0.25" />
                            <Vertex pos="-2 0.125 0.25" />
                            <Vertex pos="-2 0.125 -0.25" />
                            <Vertex pos="-2 -0.125 0.25" />
                            <Vertex pos="-2 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 1 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 -1536 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 1664 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="188" owner="0" type="0" pos="-22 -98.875 15.75" rot="1 0 0 0" scale="" transform="1 0 0 -22 0 1 0 -98.875 0 0 1 15.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 0.25" />
                            <Vertex pos="2 0.125 -0.25" />
                            <Vertex pos="2 -0.125 0.25" />
                            <Vertex pos="2 -0.125 -0.25" />
                            <Vertex pos="-2 0.125 0.25" />
                            <Vertex pos="-2 0.125 -0.25" />
                            <Vertex pos="-2 -0.125 0.25" />
                            <Vertex pos="-2 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 1 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -288 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 -1536 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 1664 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="189" owner="0" type="0" pos="-14 -101 15.75" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 -101 0 0 1 15.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_C" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="190" owner="0" type="0" pos="-14 -103.125 15.75" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 -103.125 0 0 1 15.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 0.25" />
                            <Vertex pos="2 0.125 -0.25" />
                            <Vertex pos="2 -0.125 0.25" />
                            <Vertex pos="2 -0.125 -0.25" />
                            <Vertex pos="-2 0.125 0.25" />
                            <Vertex pos="-2 0.125 -0.25" />
                            <Vertex pos="-2 -0.125 0.25" />
                            <Vertex pos="-2 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 1 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 -1536 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 1664 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="191" owner="0" type="0" pos="-14 -98.875 15.75" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 -98.875 0 0 1 15.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 0.25" />
                            <Vertex pos="2 0.125 -0.25" />
                            <Vertex pos="2 -0.125 0.25" />
                            <Vertex pos="2 -0.125 -0.25" />
                            <Vertex pos="-2 0.125 0.25" />
                            <Vertex pos="-2 0.125 -0.25" />
                            <Vertex pos="-2 -0.125 0.25" />
                            <Vertex pos="-2 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 1 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -288 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 -1536 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 1664 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="192" owner="0" type="0" pos="-10 -101 15.25" rot="1 0 0 0" scale="" transform="1 0 0 -10 0 1 0 -101 0 0 1 15.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1.99999 -0.25" />
                            <Vertex pos="2 1.99999 -0.749999" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="2 -2 -0.749999" />
                            <Vertex pos="-2 1.99999 0.749999" />
                            <Vertex pos="-2 1.99999 0.250001" />
                            <Vertex pos="-2 -2 0.749999" />
                            <Vertex pos="-2 -2 0.250001" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1.99999" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242535 0 0.970143 -0.242535" album="" material="bm_tile03_C" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.242535" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="193" owner="0" type="0" pos="-10 -103.125 15.25" rot="1 0 0 0" scale="" transform="1 0 0 -10 0 1 0 -103.125 0 0 1 15.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 -0.25" />
                            <Vertex pos="2 0.125 -0.749999" />
                            <Vertex pos="2 -0.125 -0.25" />
                            <Vertex pos="2 -0.125 -0.749999" />
                            <Vertex pos="-2 0.125 0.749999" />
                            <Vertex pos="-2 0.125 0.250001" />
                            <Vertex pos="-2 -0.125 0.749999" />
                            <Vertex pos="-2 -0.125 0.250001" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 1 0 96 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -352 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 1664 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -384 -0.25 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242535 0 0.970143 -0.242535" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 -1536 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.242535" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 1664 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="194" owner="0" type="0" pos="-10 -98.875 15.25" rot="1 0 0 0" scale="" transform="1 0 0 -10 0 1 0 -98.875 0 0 1 15.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 -0.25" />
                            <Vertex pos="2 0.125 -0.749999" />
                            <Vertex pos="2 -0.125008 -0.25" />
                            <Vertex pos="2 -0.125008 -0.749999" />
                            <Vertex pos="-2 0.125 0.749999" />
                            <Vertex pos="-2 0.125 0.250001" />
                            <Vertex pos="-2 -0.125008 0.749999" />
                            <Vertex pos="-2 -0.125008 0.250001" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 1 0 32 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -288 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 -384 -0.25 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125008" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242535 0 0.970143 -0.242535" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 -1536 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970142 -0.242535" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 1664 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="195" owner="0" type="0" pos="-6 -101 14.75" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 -101 0 0 1 14.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_C" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="196" owner="0" type="0" pos="-6 -103.125 14.75" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 -103.125 0 0 1 14.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 0.25" />
                            <Vertex pos="2 0.125 -0.25" />
                            <Vertex pos="2 -0.125 0.25" />
                            <Vertex pos="2 -0.125 -0.25" />
                            <Vertex pos="-2 0.125 0.25" />
                            <Vertex pos="-2 0.125 -0.25" />
                            <Vertex pos="-2 -0.125 0.25" />
                            <Vertex pos="-2 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 1 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 -1536 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 1664 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="197" owner="0" type="0" pos="-6 -98.875 14.75" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 -98.875 0 0 1 14.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 0.25" />
                            <Vertex pos="2 0.125 -0.25" />
                            <Vertex pos="2 -0.125 0.25" />
                            <Vertex pos="2 -0.125 -0.25" />
                            <Vertex pos="-2 0.125 0.25" />
                            <Vertex pos="-2 0.125 -0.25" />
                            <Vertex pos="-2 -0.125 0.25" />
                            <Vertex pos="-2 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 1 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -288 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 -1536 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 1664 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="198" owner="0" type="0" pos="14 -93 20.75" rot="1 0 0 0" scale="" transform="1 0 0 14 0 1 0 -93 0 0 1 20.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="14 2 0.25" />
                            <Vertex pos="14 2 -0.25" />
                            <Vertex pos="14 -2 0.25" />
                            <Vertex pos="14 -2 -0.25" />
                            <Vertex pos="-14 2 0.25" />
                            <Vertex pos="-14 2 -0.25" />
                            <Vertex pos="-14 -2 0.25" />
                            <Vertex pos="-14 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -14" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -14" album="" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -3456 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 3200 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_C" texgens="1 0 0 3584 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 -1536 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="199" owner="0" type="0" pos="14 -95.125 20.75" rot="1 0 0 0" scale="" transform="1 0 0 14 0 1 0 -95.125 0 0 1 20.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="14 0.125 0.25" />
                            <Vertex pos="14 0.125 -0.25" />
                            <Vertex pos="14 -0.125 0.25" />
                            <Vertex pos="14 -0.125 -0.25" />
                            <Vertex pos="-14 0.125 0.25" />
                            <Vertex pos="-14 0.125 -0.25" />
                            <Vertex pos="-14 -0.125 0.25" />
                            <Vertex pos="-14 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -14" album="" material="bm_edge_white_doublevert" texgens="0 1 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -14" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 1536 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 -1408 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="200" owner="0" type="0" pos="9 -90.875 20.75" rot="1 0 0 0" scale="" transform="1 0 0 9 0 1 0 -90.875 0 0 1 20.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9 0.125 0.25" />
                            <Vertex pos="9 0.125 -0.25" />
                            <Vertex pos="9 -0.125 0.25" />
                            <Vertex pos="9 -0.125 -0.25" />
                            <Vertex pos="-9 0.125 0.25" />
                            <Vertex pos="-9 0.125 -0.25" />
                            <Vertex pos="-9 -0.125 0.25" />
                            <Vertex pos="-9 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -9" album="" material="bm_edge_white_doublevert" texgens="0 1 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -9" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -288 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 256 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 -128 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="201" owner="0" type="0" pos="26 -87 20.75" rot="1 0 0 0" scale="" transform="1 0 0 26 0 1 0 -87 0 0 1 20.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 0.25" />
                            <Vertex pos="2 4 -0.25" />
                            <Vertex pos="2 -4 0.25" />
                            <Vertex pos="2 -4 -0.25" />
                            <Vertex pos="-2 4 0.25" />
                            <Vertex pos="-2 4 -0.25" />
                            <Vertex pos="-2 -4 0.25" />
                            <Vertex pos="-2 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 -6528 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 6272 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_C" texgens="1 0 0 6656 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 -3072 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="202" owner="0" type="0" pos="-51 -6 16.75" rot="1 0 0 0" scale="" transform="1 0 0 -51 0 1 0 -6 0 0 1 16.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 6 0.25" />
                            <Vertex pos="1 6 -0.25" />
                            <Vertex pos="1 -6 0.25" />
                            <Vertex pos="1 -6 -0.25" />
                            <Vertex pos="-1 6 0.25" />
                            <Vertex pos="-1 6 -0.25" />
                            <Vertex pos="-1 -6 0.25" />
                            <Vertex pos="-1 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="Blasted" material="bm_trim" texgens="-1 0 0 13056 0 0 -1 -4288 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_C" texgens="1 0 0 768 0 -1 0 2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 -128 0 -1 0 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="203" owner="0" type="0" pos="-49.875 -6 16.75" rot="1 0 0 0" scale="" transform="1 0 0 -49.875 0 1 0 -6 0 0 1 16.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 6 0.25" />
                            <Vertex pos="0.125 6 -0.25" />
                            <Vertex pos="0.125 -6 0.25" />
                            <Vertex pos="0.125 -6 -0.25" />
                            <Vertex pos="-0.125 6 0.25" />
                            <Vertex pos="-0.125 6 -0.25" />
                            <Vertex pos="-0.125 -6 0.25" />
                            <Vertex pos="-0.125 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white" texgens="0 -1 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublevert" texgens="1 0 0 32 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="204" owner="0" type="0" pos="-52.125 -6 16.75" rot="1 0 0 0" scale="" transform="1 0 0 -52.125 0 1 0 -6 0 0 1 16.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 6 0.25" />
                            <Vertex pos="0.125 6 -0.25" />
                            <Vertex pos="0.125 -6 0.25" />
                            <Vertex pos="0.125 -6 -0.25" />
                            <Vertex pos="-0.125 6 0.25" />
                            <Vertex pos="-0.125 6 -0.25" />
                            <Vertex pos="-0.125 -6 0.25" />
                            <Vertex pos="-0.125 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white" texgens="0 -1 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublevert" texgens="1 0 0 32 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="205" owner="0" type="0" pos="-37 -23 16.75" rot="1 0 0 0" scale="" transform="1 0 0 -37 0 1 0 -23 0 0 1 16.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 1 0.25" />
                            <Vertex pos="3 1 -0.25" />
                            <Vertex pos="3 -1 0.25" />
                            <Vertex pos="3 -1 -0.25" />
                            <Vertex pos="-3 1 0.25" />
                            <Vertex pos="-3 1 -0.25" />
                            <Vertex pos="-3 -1 0.25" />
                            <Vertex pos="-3 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_trim" texgens="0 1 0 -5888 0 0 -1 -4288 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_C" texgens="1 0 0 256 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="206" owner="0" type="0" pos="-37 -24.125 16.75" rot="1 0 0 0" scale="" transform="1 0 0 -37 0 1 0 -24.125 0 0 1 16.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.125 0.25" />
                            <Vertex pos="3 0.125 -0.25" />
                            <Vertex pos="3 -0.125 0.25" />
                            <Vertex pos="3 -0.125 -0.25" />
                            <Vertex pos="-3 0.125 0.25" />
                            <Vertex pos="-3 0.125 -0.25" />
                            <Vertex pos="-3 -0.125 0.25" />
                            <Vertex pos="-3 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white_doublevert" texgens="0 1 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 256 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 -128 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="207" owner="0" type="0" pos="-37 -21.875 16.75" rot="1 0 0 0" scale="" transform="1 0 0 -37 0 1 0 -21.875 0 0 1 16.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.125 0.25" />
                            <Vertex pos="3 0.125 -0.25" />
                            <Vertex pos="3 -0.125 0.25" />
                            <Vertex pos="3 -0.125 -0.25" />
                            <Vertex pos="-3 0.125 0.25" />
                            <Vertex pos="-3 0.125 -0.25" />
                            <Vertex pos="-3 -0.125 0.25" />
                            <Vertex pos="-3 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white_doublevert" texgens="0 1 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -288 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 256 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 -128 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="208" owner="0" type="0" pos="-29 -24 16.25" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 -24 0 0 1 16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 2 0.25" />
                            <Vertex pos="5 2 -0.25" />
                            <Vertex pos="5 -2 0.25" />
                            <Vertex pos="5 -2 -0.25" />
                            <Vertex pos="-5 2 0.25" />
                            <Vertex pos="-5 2 -0.25" />
                            <Vertex pos="-5 -2 0.25" />
                            <Vertex pos="-5 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="Blasted" material="bm_trim" texgens="0 -1 0 6144 0 0 -1 -4160 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_C" texgens="1 0 0 256 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 128 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="209" owner="0" type="0" pos="-29 -26.125 16.25" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 -26.125 0 0 1 16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.125 0.25" />
                            <Vertex pos="5 0.125 -0.25" />
                            <Vertex pos="5 -0.125 0.25" />
                            <Vertex pos="5 -0.125 -0.25" />
                            <Vertex pos="-5 0.125 0.25" />
                            <Vertex pos="-5 0.125 -0.25" />
                            <Vertex pos="-5 -0.125 0.25" />
                            <Vertex pos="-5 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white_doublevert" texgens="0 1 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 256 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 -128 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="210" owner="0" type="0" pos="-29 -21.875 16.25" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 -21.875 0 0 1 16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.125 0.25" />
                            <Vertex pos="5 0.125 -0.25" />
                            <Vertex pos="5 -0.125 0.25" />
                            <Vertex pos="5 -0.125 -0.25" />
                            <Vertex pos="-5 0.125 0.25" />
                            <Vertex pos="-5 0.125 -0.25" />
                            <Vertex pos="-5 -0.125 0.25" />
                            <Vertex pos="-5 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white_doublevert" texgens="0 1 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -288 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 256 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 -128 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="211" owner="0" type="0" pos="-15 -26 16.25" rot="1 0 0 0" scale="" transform="1 0 0 -15 0 1 0 -26 0 0 1 16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 2 0.25" />
                            <Vertex pos="5 2 -0.25" />
                            <Vertex pos="5 -2 0.25" />
                            <Vertex pos="5 -2 -0.25" />
                            <Vertex pos="-5 2 0.25" />
                            <Vertex pos="-5 2 -0.25" />
                            <Vertex pos="-5 -2 0.25" />
                            <Vertex pos="-5 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_C" texgens="1 0 0 256 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 128 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="212" owner="0" type="0" pos="-15 -28.125 16.25" rot="1 0 0 0" scale="" transform="1 0 0 -15 0 1 0 -28.125 0 0 1 16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.125 0.25" />
                            <Vertex pos="5 0.125 -0.25" />
                            <Vertex pos="5 -0.125 0.25" />
                            <Vertex pos="5 -0.125 -0.25" />
                            <Vertex pos="-5 0.125 0.25" />
                            <Vertex pos="-5 0.125 -0.25" />
                            <Vertex pos="-5 -0.125 0.25" />
                            <Vertex pos="-5 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white_doublevert" texgens="0 1 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 256 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 -128 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="213" owner="0" type="0" pos="-15 -23.875 16.25" rot="1 0 0 0" scale="" transform="1 0 0 -15 0 1 0 -23.875 0 0 1 16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.125 0.25" />
                            <Vertex pos="5 0.125 -0.25" />
                            <Vertex pos="5 -0.125 0.25" />
                            <Vertex pos="5 -0.125 -0.25" />
                            <Vertex pos="-5 0.125 0.25" />
                            <Vertex pos="-5 0.125 -0.25" />
                            <Vertex pos="-5 -0.125 0.25" />
                            <Vertex pos="-5 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white_doublevert" texgens="0 1 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -288 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 256 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 -128 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="214" owner="0" type="0" pos="-8 -26 16.75" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 -26 0 0 1 16.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.75" />
                            <Vertex pos="2 2 0.250002" />
                            <Vertex pos="2 -2 0.75" />
                            <Vertex pos="2 -2 0.250002" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 2 -0.749998" />
                            <Vertex pos="-2 -2 -0.25" />
                            <Vertex pos="-2 -2 -0.749998" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -0.242536" album="" material="bm_tile03_C" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.242534" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="215" owner="0" type="0" pos="-8 -28.125 16.75" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 -28.125 0 0 1 16.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 0.75" />
                            <Vertex pos="2 0.125 0.250002" />
                            <Vertex pos="2 -0.125 0.75" />
                            <Vertex pos="2 -0.125 0.250002" />
                            <Vertex pos="-2 0.125 -0.25" />
                            <Vertex pos="-2 0.125 -0.749998" />
                            <Vertex pos="-2 -0.125 -0.25" />
                            <Vertex pos="-2 -0.125 -0.749998" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_trim" texgens="0 1 0 -7200 0 0 -1 -4288 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_trim" texgens="0 -1 0 7200 0 0 -1 -4288 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_trim" texgens="-1 0 0 2048 0 0 -1 -4288 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="Blasted" material="bm_trim" texgens="1 0 0 -384 0.25 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -0.242536" album="Blasted" material="bm_trim" texgens="1 0 0 -2048 0 -1 0 7200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.242534" album="Blasted" material="bm_trim" texgens="-1 0 0 2048 0 -1 0 7200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="216" owner="0" type="0" pos="-8 -23.875 16.75" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 -23.875 0 0 1 16.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 0.75" />
                            <Vertex pos="2 0.125 0.250002" />
                            <Vertex pos="2 -0.125 0.75" />
                            <Vertex pos="2 -0.125 0.250002" />
                            <Vertex pos="-2 0.125 -0.25" />
                            <Vertex pos="-2 0.125 -0.749998" />
                            <Vertex pos="-2 -0.125 -0.25" />
                            <Vertex pos="-2 -0.125 -0.749998" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 1 0 32 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -288 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 -384 0.25 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -0.242536" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 -1536 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.242534" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 1664 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="217" owner="0" type="0" pos="-4 -26 17.25" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 -26 0 0 1 17.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_C" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="218" owner="0" type="0" pos="-4 -28.125 17.25" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 -28.125 0 0 1 17.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 0.25" />
                            <Vertex pos="2 0.125 -0.25" />
                            <Vertex pos="2 -0.125 0.25" />
                            <Vertex pos="2 -0.125 -0.25" />
                            <Vertex pos="-2 0.125 0.25" />
                            <Vertex pos="-2 0.125 -0.25" />
                            <Vertex pos="-2 -0.125 0.25" />
                            <Vertex pos="-2 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_trim" texgens="0 1 0 -7200 0 0 -1 -4416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_trim" texgens="0 -1 0 7200 0 0 -1 -4416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_trim" texgens="-1 0 0 1024 0 0 -1 -4416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="Blasted" material="bm_trim" texgens="1 0 0 -1024 0 0 -1 -4416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 -1024 0 -1 0 7200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 1024 0 -1 0 7200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="219" owner="0" type="0" pos="-4 -23.875 17.25" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 -23.875 0 0 1 17.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 0.25" />
                            <Vertex pos="2 0.125 -0.25" />
                            <Vertex pos="2 -0.125 0.25" />
                            <Vertex pos="2 -0.125 -0.25" />
                            <Vertex pos="-2 0.125 0.25" />
                            <Vertex pos="-2 0.125 -0.25" />
                            <Vertex pos="-2 -0.125 0.25" />
                            <Vertex pos="-2 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 1 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -288 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 -1536 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 1664 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="220" owner="0" type="0" pos="17 -36 17.25" rot="1 0 0 0" scale="" transform="1 0 0 17 0 1 0 -36 0 0 1 17.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 2 0.25" />
                            <Vertex pos="7 2 -0.25" />
                            <Vertex pos="7 -2 0.25" />
                            <Vertex pos="7 -2 -0.25" />
                            <Vertex pos="-7 2 0.25" />
                            <Vertex pos="-7 2 -0.25" />
                            <Vertex pos="-7 -2 0.25" />
                            <Vertex pos="-7 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -7" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -7" album="" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_C" texgens="1 0 0 1792 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 -640 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="221" owner="0" type="0" pos="21 -42 17.25" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 -42 0 0 1 17.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 4 0.25" />
                            <Vertex pos="3 4 -0.25" />
                            <Vertex pos="3 -8 0.25" />
                            <Vertex pos="3 -8 -0.25" />
                            <Vertex pos="-3 4 0.25" />
                            <Vertex pos="-3 4 -0.25" />
                            <Vertex pos="-3 -8 0.25" />
                            <Vertex pos="-3 -8 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 -2688 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_edge_white" texgens="1 0 0 2432 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_C" texgens="1 0 0 2816 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 -1152 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="222" owner="0" type="0" pos="-52 4 17.25" rot="1 0 0 0" scale="" transform="1 0 0 -52 0 1 0 4 0 0 1 17.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 0.25" />
                            <Vertex pos="2 4 -0.25" />
                            <Vertex pos="2 -4 0.25" />
                            <Vertex pos="2 -4 -0.25" />
                            <Vertex pos="-2 4 0.25" />
                            <Vertex pos="-2 4 -0.25" />
                            <Vertex pos="-2 -4 0.25" />
                            <Vertex pos="-2 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="Blasted" material="bm_trim" texgens="1 0 0 -13312 0 0 -1 -4416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_C" texgens="1 0 0 512 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="223" owner="0" type="0" pos="-49.875 4 17.25" rot="1 0 0 0" scale="" transform="1 0 0 -49.875 0 1 0 4 0 0 1 17.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 4 0.25" />
                            <Vertex pos="0.125 4 -0.25" />
                            <Vertex pos="0.125 -4 0.25" />
                            <Vertex pos="0.125 -4 -0.25" />
                            <Vertex pos="-0.125 4 0.25" />
                            <Vertex pos="-0.125 4 -0.25" />
                            <Vertex pos="-0.125 -4 0.25" />
                            <Vertex pos="-0.125 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white" texgens="0 1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white" texgens="0 -1 0 -1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublevert" texgens="1 0 0 32 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="224" owner="0" type="0" pos="-54.125 4 17.25" rot="1 0 0 0" scale="" transform="1 0 0 -54.125 0 1 0 4 0 0 1 17.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 4 0.25" />
                            <Vertex pos="0.125 4 -0.25" />
                            <Vertex pos="0.125 -4 0.25" />
                            <Vertex pos="0.125 -4 -0.25" />
                            <Vertex pos="-0.125 4 0.25" />
                            <Vertex pos="-0.125 4 -0.25" />
                            <Vertex pos="-0.125 -4 0.25" />
                            <Vertex pos="-0.125 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white" texgens="0 1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white" texgens="0 -1 0 -1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublevert" texgens="1 0 0 32 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="227" owner="0" type="0" pos="-27 28 17.75" rot="1 0 0 0" scale="" transform="1 0 0 -27 0 1 0 28 0 0 1 17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_C" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="228" owner="0" type="0" pos="-27 25.875 17.75" rot="1 0 0 0" scale="" transform="1 0 0 -27 0 1 0 25.875 0 0 1 17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 0.25" />
                            <Vertex pos="2 0.125 -0.25" />
                            <Vertex pos="2 -0.125 0.25" />
                            <Vertex pos="2 -0.125 -0.25" />
                            <Vertex pos="-2 0.125 0.25" />
                            <Vertex pos="-2 0.125 -0.25" />
                            <Vertex pos="-2 -0.125 0.25" />
                            <Vertex pos="-2 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 1 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 -1536 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 1664 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="229" owner="0" type="0" pos="-27 30.125 17.75" rot="1 0 0 0" scale="" transform="1 0 0 -27 0 1 0 30.125 0 0 1 17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 0.25" />
                            <Vertex pos="2 0.125 -0.25" />
                            <Vertex pos="2 -0.125 0.25" />
                            <Vertex pos="2 -0.125 -0.25" />
                            <Vertex pos="-2 0.125 0.25" />
                            <Vertex pos="-2 0.125 -0.25" />
                            <Vertex pos="-2 -0.125 0.25" />
                            <Vertex pos="-2 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 1 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -288 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 -1536 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 1664 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="230" owner="0" type="0" pos="-23 28 18.25" rot="1 0 0 0" scale="" transform="1 0 0 -23 0 1 0 28 0 0 1 18.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.75" />
                            <Vertex pos="2 2 0.249998" />
                            <Vertex pos="2 -2 0.75" />
                            <Vertex pos="2 -2 0.249998" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 2 -0.750002" />
                            <Vertex pos="-2 -2 -0.25" />
                            <Vertex pos="-2 -2 -0.750002" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -0.242536" album="" material="bm_tile03_C" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.242538" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="231" owner="0" type="0" pos="-23 25.875 18.25" rot="1 0 0 0" scale="" transform="1 0 0 -23 0 1 0 25.875 0 0 1 18.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 0.75" />
                            <Vertex pos="2 0.125 0.249998" />
                            <Vertex pos="2 -0.125 0.75" />
                            <Vertex pos="2 -0.125 0.249998" />
                            <Vertex pos="-2 0.125 -0.25" />
                            <Vertex pos="-2 0.125 -0.750002" />
                            <Vertex pos="-2 -0.125 -0.25" />
                            <Vertex pos="-2 -0.125 -0.750002" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 1 0 96 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -352 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 1664 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -384 0.25 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -0.242536" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 -1536 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.242538" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 1664 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="232" owner="0" type="0" pos="-23 30.125 18.25" rot="1 0 0 0" scale="" transform="1 0 0 -23 0 1 0 30.125 0 0 1 18.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 0.75" />
                            <Vertex pos="2 0.125 0.249998" />
                            <Vertex pos="2 -0.125 0.75" />
                            <Vertex pos="2 -0.125 0.249998" />
                            <Vertex pos="-2 0.125 -0.25" />
                            <Vertex pos="-2 0.125 -0.750002" />
                            <Vertex pos="-2 -0.125 -0.25" />
                            <Vertex pos="-2 -0.125 -0.750002" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 1 0 32 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -288 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 -384 0.25 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -0.242536" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 -1536 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.242538" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 1664 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="233" owner="0" type="0" pos="-19 28 18.75" rot="1 0 0 0" scale="" transform="1 0 0 -19 0 1 0 28 0 0 1 18.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_C" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="234" owner="0" type="0" pos="-19 25.875 18.75" rot="1 0 0 0" scale="" transform="1 0 0 -19 0 1 0 25.875 0 0 1 18.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 0.25" />
                            <Vertex pos="2 0.125 -0.25" />
                            <Vertex pos="2 -0.125 0.25" />
                            <Vertex pos="2 -0.125 -0.25" />
                            <Vertex pos="-2 0.125 0.25" />
                            <Vertex pos="-2 0.125 -0.25" />
                            <Vertex pos="-2 -0.125 0.25" />
                            <Vertex pos="-2 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 1 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 -1536 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 1664 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="235" owner="0" type="0" pos="-19 30.125 18.75" rot="1 0 0 0" scale="" transform="1 0 0 -19 0 1 0 30.125 0 0 1 18.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 0.25" />
                            <Vertex pos="2 0.125 -0.25" />
                            <Vertex pos="2 -0.125 0.25" />
                            <Vertex pos="2 -0.125 -0.25" />
                            <Vertex pos="-2 0.125 0.25" />
                            <Vertex pos="-2 0.125 -0.25" />
                            <Vertex pos="-2 -0.125 0.25" />
                            <Vertex pos="-2 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 1 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -288 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 -1536 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 1664 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="236" owner="0" type="0" pos="-43 28 18.75" rot="1 0 0 0" scale="" transform="1 0 0 -43 0 1 0 28 0 0 1 18.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_C" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="237" owner="0" type="0" pos="-43 25.875 18.75" rot="1 0 0 0" scale="" transform="1 0 0 -43 0 1 0 25.875 0 0 1 18.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 0.25" />
                            <Vertex pos="2 0.125 -0.25" />
                            <Vertex pos="2 -0.125 0.25" />
                            <Vertex pos="2 -0.125 -0.25" />
                            <Vertex pos="-2 0.125 0.25" />
                            <Vertex pos="-2 0.125 -0.25" />
                            <Vertex pos="-2 -0.125 0.25" />
                            <Vertex pos="-2 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 1 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 -1536 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 1664 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="238" owner="0" type="0" pos="-43 30.125 18.75" rot="1 0 0 0" scale="" transform="1 0 0 -43 0 1 0 30.125 0 0 1 18.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 0.25" />
                            <Vertex pos="2 0.125 -0.25" />
                            <Vertex pos="2 -0.125 0.25" />
                            <Vertex pos="2 -0.125 -0.25" />
                            <Vertex pos="-2 0.125 0.25" />
                            <Vertex pos="-2 0.125 -0.25" />
                            <Vertex pos="-2 -0.125 0.25" />
                            <Vertex pos="-2 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 1 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -288 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 -1536 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 1664 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="239" owner="0" type="0" pos="-39 28 18.25" rot="1 0 0 0" scale="" transform="1 0 0 -39 0 1 0 28 0 0 1 18.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 2 -0.75" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="2 -2 -0.75" />
                            <Vertex pos="-2 2 0.75" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 -2 0.75" />
                            <Vertex pos="-2 -2 0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.242536" album="" material="bm_tile03_C" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.242536" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="240" owner="0" type="0" pos="-39 25.875 18.25" rot="1 0 0 0" scale="" transform="1 0 0 -39 0 1 0 25.875 0 0 1 18.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 -0.25" />
                            <Vertex pos="2 0.125 -0.75" />
                            <Vertex pos="2 -0.125 -0.25" />
                            <Vertex pos="2 -0.125 -0.75" />
                            <Vertex pos="-2 0.125 0.75" />
                            <Vertex pos="-2 0.125 0.25" />
                            <Vertex pos="-2 -0.125 0.75" />
                            <Vertex pos="-2 -0.125 0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 1 0 96 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -352 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 1664 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -384 -0.25 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.242536" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 -1536 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.242536" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 1664 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="241" owner="0" type="0" pos="-39 30.125 18.25" rot="1 0 0 0" scale="" transform="1 0 0 -39 0 1 0 30.125 0 0 1 18.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 -0.25" />
                            <Vertex pos="2 0.125 -0.75" />
                            <Vertex pos="2 -0.125 -0.25" />
                            <Vertex pos="2 -0.125 -0.75" />
                            <Vertex pos="-2 0.125 0.75" />
                            <Vertex pos="-2 0.125 0.25" />
                            <Vertex pos="-2 -0.125 0.75" />
                            <Vertex pos="-2 -0.125 0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 1 0 32 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -288 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 -384 -0.25 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.242536" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 -1536 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.242536" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 1664 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="242" owner="0" type="0" pos="-35 28 17.75" rot="1 0 0 0" scale="" transform="1 0 0 -35 0 1 0 28 0 0 1 17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_C" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="243" owner="0" type="0" pos="-35 25.875 17.75" rot="1 0 0 0" scale="" transform="1 0 0 -35 0 1 0 25.875 0 0 1 17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 0.25" />
                            <Vertex pos="2 0.125 -0.25" />
                            <Vertex pos="2 -0.125 0.25" />
                            <Vertex pos="2 -0.125 -0.25" />
                            <Vertex pos="-2 0.125 0.25" />
                            <Vertex pos="-2 0.125 -0.25" />
                            <Vertex pos="-2 -0.125 0.25" />
                            <Vertex pos="-2 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 1 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 -1536 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 1664 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="244" owner="0" type="0" pos="-35 30.125 17.75" rot="1 0 0 0" scale="" transform="1 0 0 -35 0 1 0 30.125 0 0 1 17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 0.25" />
                            <Vertex pos="2 0.125 -0.25" />
                            <Vertex pos="2 -0.125 0.25" />
                            <Vertex pos="2 -0.125 -0.25" />
                            <Vertex pos="-2 0.125 0.25" />
                            <Vertex pos="-2 0.125 -0.25" />
                            <Vertex pos="-2 -0.125 0.25" />
                            <Vertex pos="-2 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 1 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -288 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 -1536 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 1664 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="247" owner="0" type="0" pos="-10 54 20.25" rot="1 0 0 0" scale="" transform="1 0 0 -10 0 1 0 54 0 0 1 20.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 6 0.25" />
                            <Vertex pos="2 6 -0.25" />
                            <Vertex pos="2 -6 0.25" />
                            <Vertex pos="2 -6 -0.25" />
                            <Vertex pos="-2 6 0.25" />
                            <Vertex pos="-2 6 -0.25" />
                            <Vertex pos="-2 -6 0.25" />
                            <Vertex pos="-2 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 -2432 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 2176 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_C" texgens="1 0 0 2560 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 -1024 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="249" owner="0" type="0" pos="-10 87 20.25" rot="1 0 0 0" scale="" transform="1 0 0 -10 0 1 0 87 0 0 1 20.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 0.25" />
                            <Vertex pos="2 4 -0.25" />
                            <Vertex pos="2 -4 0.25" />
                            <Vertex pos="2 -4 -0.25" />
                            <Vertex pos="-2 4 0.25" />
                            <Vertex pos="-2 4 -0.25" />
                            <Vertex pos="-2 -4 0.25" />
                            <Vertex pos="-2 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 -2432 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 2176 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_C" texgens="1 0 0 2560 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 -1024 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="256" owner="0" type="0" pos="-10 153 20.25" rot="1 0 0 0" scale="" transform="1 0 0 -10 0 1 0 153 0 0 1 20.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 6 0.25" />
                            <Vertex pos="2 6 -0.25" />
                            <Vertex pos="2 -6 0.25" />
                            <Vertex pos="2 -6 -0.25" />
                            <Vertex pos="-2 6 0.25" />
                            <Vertex pos="-2 6 -0.25" />
                            <Vertex pos="-2 -6 0.25" />
                            <Vertex pos="-2 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 -2432 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 2176 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_C" texgens="1 0 0 2560 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 -1024 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="259" owner="0" type="0" pos="-10 186 20.25" rot="1 0 0 0" scale="" transform="1 0 0 -10 0 1 0 186 0 0 1 20.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 0.25" />
                            <Vertex pos="2 4 -0.25" />
                            <Vertex pos="2 -4 0.25" />
                            <Vertex pos="2 -4 -0.25" />
                            <Vertex pos="-2 4 0.25" />
                            <Vertex pos="-2 4 -0.25" />
                            <Vertex pos="-2 -4 0.25" />
                            <Vertex pos="-2 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 -2432 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 2176 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile03_C" texgens="1 0 0 2560 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 -1024 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="302" owner="0" type="0" pos="-6.125 -5 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -6.125 0 1 0 -5 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 7.25 0.25" />
                            <Vertex pos="0.125 7.25 -0.25" />
                            <Vertex pos="0.125 2.75 0.25" />
                            <Vertex pos="0.125 2.75 -0.25" />
                            <Vertex pos="-0.125 7.25 0.25" />
                            <Vertex pos="-0.125 7.25 -0.25" />
                            <Vertex pos="-0.125 2.75 0.25" />
                            <Vertex pos="-0.125 2.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 1 0 -1280 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 -1 0 1280 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -7.25" album="Blasted" material="bm_trim" texgens="-1 0 0 1568 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 2.75" album="Blasted" material="bm_trim" texgens="1 0 0 -1568 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 -1568 0 -1 0 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 1568 0 -1 0 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="303" owner="0" type="0" pos="-9.875 0 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -9.875 0 1 0 0 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 2.25 0.25" />
                            <Vertex pos="0.125 2.25 -0.25" />
                            <Vertex pos="0.125 -2.25 0.25" />
                            <Vertex pos="0.125 -2.25 -0.25" />
                            <Vertex pos="-0.125 2.25 0.25" />
                            <Vertex pos="-0.125 2.25 -0.25" />
                            <Vertex pos="-0.125 -2.25 0.25" />
                            <Vertex pos="-0.125 -2.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 1 0 0 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 -1 0 0 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.25" album="Blasted" material="bm_trim" texgens="-1 0 0 2528 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.25" album="Blasted" material="bm_trim" texgens="1 0 0 -2528 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 -2528 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 2528 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="304" owner="0" type="0" pos="-18.125 -5 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -18.125 0 1 0 -5 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 7.25 0.25" />
                            <Vertex pos="0.125 7.25 -0.25" />
                            <Vertex pos="0.125 2.75 0.25" />
                            <Vertex pos="0.125 2.75 -0.25" />
                            <Vertex pos="-0.125 7.25 0.25" />
                            <Vertex pos="-0.125 7.25 -0.25" />
                            <Vertex pos="-0.125 2.75 0.25" />
                            <Vertex pos="-0.125 2.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 1 0 -1280 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 -1 0 1280 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -7.25" album="Blasted" material="bm_trim" texgens="-1 0 0 4640 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 2.75" album="Blasted" material="bm_trim" texgens="1 0 0 -4640 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 -4640 0 -1 0 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 4640 0 -1 0 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="305" owner="0" type="0" pos="-21.875 0 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -21.875 0 1 0 0 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 2.25 0.25" />
                            <Vertex pos="0.125 2.25 -0.25" />
                            <Vertex pos="0.125 -2.25 0.25" />
                            <Vertex pos="0.125 -2.25 -0.25" />
                            <Vertex pos="-0.125 2.25 0.25" />
                            <Vertex pos="-0.125 2.25 -0.25" />
                            <Vertex pos="-0.125 -2.25 0.25" />
                            <Vertex pos="-0.125 -2.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 1 0 0 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 -1 0 0 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.25" album="Blasted" material="bm_trim" texgens="-1 0 0 5600 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.25" album="Blasted" material="bm_trim" texgens="1 0 0 -5600 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 -5600 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 5600 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="306" owner="0" type="0" pos="-49.875 -93 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -49.875 0 1 0 -93 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 2 0.25" />
                            <Vertex pos="0.125 2 -0.25" />
                            <Vertex pos="0.125 -2 0.25" />
                            <Vertex pos="0.125 -2 -0.25" />
                            <Vertex pos="-0.125 2 0.25" />
                            <Vertex pos="-0.125 2 -0.25" />
                            <Vertex pos="-0.125 -2 0.25" />
                            <Vertex pos="-0.125 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 1 0 -23808 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 -1 0 23808 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_trim" texgens="-1 0 0 12768 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_trim" texgens="1 0 0 -12768 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 -12768 0 -1 0 23808 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 12768 0 -1 0 23808 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="307" owner="0" type="0" pos="-34.125 -5 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -34.125 0 1 0 -5 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 7 0.25" />
                            <Vertex pos="0.125 7 -0.25" />
                            <Vertex pos="0.125 5 0.25" />
                            <Vertex pos="0.125 5 -0.25" />
                            <Vertex pos="-0.125 7 0.25" />
                            <Vertex pos="-0.125 7 -0.25" />
                            <Vertex pos="-0.125 5 0.25" />
                            <Vertex pos="-0.125 5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white" texgens="0 1 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white" texgens="0 -1 0 -1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -7" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 5" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublevert" texgens="1 0 0 32 0 -1 0 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 -1 0 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="308" owner="0" type="0" pos="-34.125 2.125 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -34.125 0 1 0 2.125 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.125 0.25" />
                            <Vertex pos="0.125 0.125 -0.25" />
                            <Vertex pos="0.125 -0.125 0.25" />
                            <Vertex pos="0.125 -0.125 -0.25" />
                            <Vertex pos="-0.125 0.125 0.25" />
                            <Vertex pos="-0.125 0.125 -0.25" />
                            <Vertex pos="-0.125 -0.125 0.25" />
                            <Vertex pos="-0.125 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white_doublevert" texgens="0 1 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -288 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_half" texgens="1 0 0 32 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="64 64">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_half" texgens="-1 0 0 96 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="64 64">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="309" owner="0" type="0" pos="-50 -27.875 1.25" rot="1 0 0 0" scale="" transform="1 0 0 -50 0 1 0 -27.875 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2 0.125 0.25" />
                            <Vertex pos="-2 0.125 -0.25" />
                            <Vertex pos="-2 -0.125 0.25" />
                            <Vertex pos="-2 -0.125 -0.25" />
                            <Vertex pos="-4 0.125 0.25" />
                            <Vertex pos="-4 0.125 -0.25" />
                            <Vertex pos="-4 -0.125 0.25" />
                            <Vertex pos="-4 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 2" album="" material="bm_edge_white_doublevert" texgens="0 1 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -288 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 0 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 128 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="310" owner="0" type="0" pos="-54.125 -27.875 1.25" rot="1 0 0 0" scale="" transform="1 0 0 -54.125 0 1 0 -27.875 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.125 0.25" />
                            <Vertex pos="0.125 0.125 -0.25" />
                            <Vertex pos="0.125 -0.125 0.25" />
                            <Vertex pos="0.125 -0.125 -0.25" />
                            <Vertex pos="-0.125 0.125 0.25" />
                            <Vertex pos="-0.125 0.125 -0.25" />
                            <Vertex pos="-0.125 -0.125 0.25" />
                            <Vertex pos="-0.125 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white_doublevert" texgens="0 1 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -288 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_half" texgens="1 0 0 32 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="64 64">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_half" texgens="-1 0 0 96 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="64 64">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="311" owner="0" type="0" pos="-50.5 -36.125 1.25" rot="1 0 0 0" scale="" transform="1 0 0 -50.5 0 1 0 -36.125 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.75 0.125 0.25" />
                            <Vertex pos="0.75 0.125 -0.25" />
                            <Vertex pos="0.75 -0.125 0.25" />
                            <Vertex pos="0.75 -0.125 -0.25" />
                            <Vertex pos="-3.75 0.125 0.25" />
                            <Vertex pos="-3.75 0.125 -0.25" />
                            <Vertex pos="-3.75 -0.125 0.25" />
                            <Vertex pos="-3.75 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.75" album="Blasted" material="bm_trim" texgens="0 1 0 -9248 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.75" album="Blasted" material="bm_trim" texgens="0 -1 0 9248 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_trim" texgens="-1 0 0 12928 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="Blasted" material="bm_trim" texgens="1 0 0 -12928 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 -12928 0 -1 0 9248 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 12928 0 -1 0 9248 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="312" owner="0" type="0" pos="-50.5 -88.875 2.75" rot="1 0 0 0" scale="" transform="1 0 0 -50.5 0 1 0 -88.875 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.75 0.125 0.25" />
                            <Vertex pos="0.75 0.125 -0.25" />
                            <Vertex pos="0.75 -0.125 0.25" />
                            <Vertex pos="0.75 -0.125 -0.25" />
                            <Vertex pos="-3.75 0.125 0.25" />
                            <Vertex pos="-3.75 0.125 -0.25" />
                            <Vertex pos="-3.75 -0.125 0.25" />
                            <Vertex pos="-3.75 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.75" album="Blasted" material="bm_trim" texgens="0 1 0 -22752 0 0 -1 -704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.75" album="Blasted" material="bm_trim" texgens="0 -1 0 22752 0 0 -1 -704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_trim" texgens="-1 0 0 12928 0 0 -1 -704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="Blasted" material="bm_trim" texgens="1 0 0 -12928 0 0 -1 -704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 -12928 0 -1 0 22752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 12928 0 -1 0 22752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="347" owner="0" type="0" pos="-48.125 -98 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -48.125 0 1 0 -98 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 7.25 0.25" />
                            <Vertex pos="0.125 7.25 -0.25" />
                            <Vertex pos="0.125 2.75 0.25" />
                            <Vertex pos="0.125 2.75 -0.25" />
                            <Vertex pos="-0.125 7.25 0.25" />
                            <Vertex pos="-0.125 7.25 -0.25" />
                            <Vertex pos="-0.125 2.75 0.25" />
                            <Vertex pos="-0.125 2.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 1 0 -25088 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 -1 0 25088 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -7.25" album="Blasted" material="bm_trim" texgens="-1 0 0 12320 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 2.75" album="Blasted" material="bm_trim" texgens="1 0 0 -12320 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 -12320 0 -1 0 25088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 12320 0 -1 0 25088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="348" owner="0" type="0" pos="-32.125 -106 14.75" rot="1 0 0 0" scale="" transform="1 0 0 -32.125 0 1 0 -106 0 0 1 14.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 7.25 0.25" />
                            <Vertex pos="0.125 7.25 -0.25" />
                            <Vertex pos="0.125 2.75 0.25" />
                            <Vertex pos="0.125 2.75 -0.25" />
                            <Vertex pos="-0.125 7.25 0.25" />
                            <Vertex pos="-0.125 7.25 -0.25" />
                            <Vertex pos="-0.125 2.75 0.25" />
                            <Vertex pos="-0.125 2.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 1 0 -27136 0 0 -1 -3776 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 -1 0 27136 0 0 -1 -3776 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -7.25" album="Blasted" material="bm_trim" texgens="-1 0 0 8224 0 0 -1 -3776 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 2.75" album="Blasted" material="bm_trim" texgens="1 0 0 -8224 0 0 -1 -3776 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 -8224 0 -1 0 27136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 8224 0 -1 0 27136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="349" owner="0" type="0" pos="-35.875 -93 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -35.875 0 1 0 -93 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 2.25 0.25" />
                            <Vertex pos="0.125 2.25 -0.25" />
                            <Vertex pos="0.125 -2.25 0.25" />
                            <Vertex pos="0.125 -2.25 -0.25" />
                            <Vertex pos="-0.125 2.25 0.25" />
                            <Vertex pos="-0.125 2.25 -0.25" />
                            <Vertex pos="-0.125 -2.25 0.25" />
                            <Vertex pos="-0.125 -2.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 1 0 -23808 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 -1 0 23808 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.25" album="Blasted" material="bm_trim" texgens="-1 0 0 9184 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.25" album="Blasted" material="bm_trim" texgens="1 0 0 -9184 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 -9184 0 -1 0 23808 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 9184 0 -1 0 23808 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="350" owner="0" type="0" pos="-16.125 -106 15.75" rot="1 0 0 0" scale="" transform="1 0 0 -16.125 0 1 0 -106 0 0 1 15.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 7.25 0.25" />
                            <Vertex pos="0.125 7.25 -0.25" />
                            <Vertex pos="0.125 2.75 0.25" />
                            <Vertex pos="0.125 2.75 -0.25" />
                            <Vertex pos="-0.125 7.25 0.25" />
                            <Vertex pos="-0.125 7.25 -0.25" />
                            <Vertex pos="-0.125 2.75 0.25" />
                            <Vertex pos="-0.125 2.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 1 0 -27136 0 0 -1 -4032 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 -1 0 27136 0 0 -1 -4032 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -7.25" album="Blasted" material="bm_trim" texgens="-1 0 0 4128 0 0 -1 -4032 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 2.75" album="Blasted" material="bm_trim" texgens="1 0 0 -4128 0 0 -1 -4032 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 -4128 0 -1 0 27136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 4128 0 -1 0 27136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="351" owner="0" type="0" pos="-19.875 -101 15.75" rot="1 0 0 0" scale="" transform="1 0 0 -19.875 0 1 0 -101 0 0 1 15.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 2.25 0.25" />
                            <Vertex pos="0.125 2.25 -0.25" />
                            <Vertex pos="0.125 -2.25 0.25" />
                            <Vertex pos="0.125 -2.25 -0.25" />
                            <Vertex pos="-0.125 2.25 0.25" />
                            <Vertex pos="-0.125 2.25 -0.25" />
                            <Vertex pos="-0.125 -2.25 0.25" />
                            <Vertex pos="-0.125 -2.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 1 0 -25856 0 0 -1 -4032 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 -1 0 25856 0 0 -1 -4032 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.25" album="Blasted" material="bm_trim" texgens="-1 0 0 5088 0 0 -1 -4032 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.25" album="Blasted" material="bm_trim" texgens="1 0 0 -5088 0 0 -1 -4032 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 -5088 0 -1 0 25856 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 5088 0 -1 0 25856 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="352" owner="0" type="0" pos="-3.875 -101 14.75" rot="1 0 0 0" scale="" transform="1 0 0 -3.875 0 1 0 -101 0 0 1 14.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 2.25 0.25" />
                            <Vertex pos="0.125 2.25 -0.25" />
                            <Vertex pos="0.125 -2.25 0.25" />
                            <Vertex pos="0.125 -2.25 -0.25" />
                            <Vertex pos="-0.125 2.25 0.25" />
                            <Vertex pos="-0.125 2.25 -0.25" />
                            <Vertex pos="-0.125 -2.25 0.25" />
                            <Vertex pos="-0.125 -2.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 1 0 -25856 0 0 -1 -3776 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 -1 0 25856 0 0 -1 -3776 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.25" album="Blasted" material="bm_trim" texgens="-1 0 0 992 0 0 -1 -3776 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.25" album="Blasted" material="bm_trim" texgens="1 0 0 -992 0 0 -1 -3776 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 -992 0 -1 0 25856 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 992 0 -1 0 25856 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="353" owner="0" type="0" pos="-0.125 -98 20.75" rot="1 0 0 0" scale="" transform="1 0 0 -0.125 0 1 0 -98 0 0 1 20.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 7.25 0.25" />
                            <Vertex pos="0.125 7.25 -0.25" />
                            <Vertex pos="0.125 2.75 0.25" />
                            <Vertex pos="0.125 2.75 -0.25" />
                            <Vertex pos="-0.125 7.25 0.25" />
                            <Vertex pos="-0.125 7.25 -0.25" />
                            <Vertex pos="-0.125 2.75 0.25" />
                            <Vertex pos="-0.125 2.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 1 0 -25088 0 0 -1 -5312 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 -1 0 25088 0 0 -1 -5312 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -7.25" album="Blasted" material="bm_trim" texgens="-1 0 0 32 0 0 -1 -5312 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 2.75" album="Blasted" material="bm_trim" texgens="1 0 0 -32 0 0 -1 -5312 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 -32 0 -1 0 25088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 32 0 -1 0 25088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="354" owner="0" type="0" pos="23.875 -90 20.75" rot="1 0 0 0" scale="" transform="1 0 0 23.875 0 1 0 -90 0 0 1 20.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 7 0.25" />
                            <Vertex pos="0.125 7 -0.25" />
                            <Vertex pos="0.125 -0.75 0.25" />
                            <Vertex pos="0.125 -0.75 -0.25" />
                            <Vertex pos="-0.125 7 0.25" />
                            <Vertex pos="-0.125 7 -0.25" />
                            <Vertex pos="-0.125 -0.75 0.25" />
                            <Vertex pos="-0.125 -0.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 1 0 -23040 0 0 -1 -5312 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 -1 0 23040 0 0 -1 -5312 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -7" album="Blasted" material="bm_trim" texgens="-1 0 0 -6112 0 0 -1 -5312 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.75" album="Blasted" material="bm_trim" texgens="1 0 0 6112 0 0 -1 -5312 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 6112 0 -1 0 23040 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 -6112 0 -1 0 23040 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="355" owner="0" type="0" pos="21.5 -90.875 20.75" rot="1 0 0 0" scale="" transform="1 0 0 21.5 0 1 0 -90.875 0 0 1 20.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.5 0.125 0.25" />
                            <Vertex pos="2.5 0.125 -0.25" />
                            <Vertex pos="2.5 -0.125 0.25" />
                            <Vertex pos="2.5 -0.125 -0.25" />
                            <Vertex pos="-3.5 0.125 0.25" />
                            <Vertex pos="-3.5 0.125 -0.25" />
                            <Vertex pos="-3.5 -0.125 0.25" />
                            <Vertex pos="-3.5 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.5" album="Blasted" material="bm_trim" texgens="0 1 0 -23264 0 0 -1 -5312 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.5" album="Blasted" material="bm_trim" texgens="0 -1 0 23264 0 0 -1 -5312 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_trim" texgens="-1 0 0 -5504 0 0 -1 -5312 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="Blasted" material="bm_trim" texgens="1 0 0 5504 0 0 -1 -5312 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 5504 0 -1 0 23264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 -5504 0 -1 0 23264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="356" owner="0" type="0" pos="-50.5 -99.125 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -50.5 0 1 0 -99.125 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.75 0.125 0.25" />
                            <Vertex pos="0.75 0.125 -0.25" />
                            <Vertex pos="0.75 -0.125 0.25" />
                            <Vertex pos="0.75 -0.125 -0.25" />
                            <Vertex pos="-3.75 0.125 0.25" />
                            <Vertex pos="-3.75 0.125 -0.25" />
                            <Vertex pos="-3.75 -0.125 0.25" />
                            <Vertex pos="-3.75 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.75" album="Blasted" material="bm_trim" texgens="0 1 0 -25376 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.75" album="Blasted" material="bm_trim" texgens="0 -1 0 25376 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_trim" texgens="-1 0 0 12928 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="Blasted" material="bm_trim" texgens="1 0 0 -12928 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 -12928 0 -1 0 25376 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 12928 0 -1 0 25376 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="357" owner="0" type="0" pos="-10 119 24" rot="1 0 0 0" scale="" transform="1 0 0 -10 0 1 0 119 0 0 1 24 0 0 0 1" group="-1" locked="0" nextFaceID="101" nextVertexID="65">
                        <Vertices>
                            <Vertex pos="3.92314 0.780365 -2.75" />
                            <Vertex pos="3.92314 0.780365 3" />
                            <Vertex pos="4 0 -2.75" />
                            <Vertex pos="4 -5.82726e-013 3" />
                            <Vertex pos="3.69552 1.53073 -2.75" />
                            <Vertex pos="3.69552 1.53073 3" />
                            <Vertex pos="3.32588 2.22227 -2.75" />
                            <Vertex pos="3.32588 2.22228 3" />
                            <Vertex pos="2.82843 2.82843 -2.75" />
                            <Vertex pos="2.82843 2.82843 3" />
                            <Vertex pos="2.22228 3.32587 -2.75" />
                            <Vertex pos="2.22228 3.32588 3" />
                            <Vertex pos="1.53072 3.69552 -2.75" />
                            <Vertex pos="1.53072 3.69552 3" />
                            <Vertex pos="0.780345 3.92314 -2.75" />
                            <Vertex pos="0.780345 3.92314 3" />
                            <Vertex pos="-1.43051e-005 4 -2.75" />
                            <Vertex pos="-1.45943e-005 4 3" />
                            <Vertex pos="-0.780378 3.92314 -2.75" />
                            <Vertex pos="-0.780378 3.92314 3" />
                            <Vertex pos="-1.53075 3.69551 -2.75" />
                            <Vertex pos="-1.53075 3.69551 3" />
                            <Vertex pos="-2.22226 3.32589 -2.75" />
                            <Vertex pos="-2.22226 3.32589 3" />
                            <Vertex pos="-2.82841 2.82844 -2.75" />
                            <Vertex pos="-2.82841 2.82844 3" />
                            <Vertex pos="-3.32587 2.22229 -2.75" />
                            <Vertex pos="-3.32587 2.22229 3" />
                            <Vertex pos="-3.69551 1.53075 -2.75" />
                            <Vertex pos="-3.69551 1.53075 3" />
                            <Vertex pos="-3.92314 0.780365 -2.75" />
                            <Vertex pos="-3.92314 0.780368 3" />
                            <Vertex pos="-4 7.62939e-006 -2.75" />
                            <Vertex pos="-4 9.72956e-006 3" />
                            <Vertex pos="-3.92314 -0.78035 -2.75" />
                            <Vertex pos="-3.92314 -0.780351 3" />
                            <Vertex pos="-3.69552 -1.53073 -2.75" />
                            <Vertex pos="-3.69552 -1.53073 3" />
                            <Vertex pos="-3.32588 -2.22228 -2.75" />
                            <Vertex pos="-3.32588 -2.22228 3" />
                            <Vertex pos="-2.82843 -2.82842 -2.75" />
                            <Vertex pos="-2.82843 -2.82842 3" />
                            <Vertex pos="-2.22228 -3.32588 -2.75" />
                            <Vertex pos="-2.22228 -3.32588 3" />
                            <Vertex pos="-1.53073 -3.69552 -2.75" />
                            <Vertex pos="-1.53073 -3.69552 3" />
                            <Vertex pos="-0.78036 -3.92314 -2.75" />
                            <Vertex pos="-0.780361 -3.92314 3" />
                            <Vertex pos="4.76837e-006 -4 -2.75" />
                            <Vertex pos="4.86478e-006 -4 3" />
                            <Vertex pos="0.78036 -3.92314 -2.75" />
                            <Vertex pos="0.78036 -3.92314 3" />
                            <Vertex pos="1.53075 -3.69551 -2.75" />
                            <Vertex pos="1.53075 -3.69551 3" />
                            <Vertex pos="2.22229 -3.32587 -2.75" />
                            <Vertex pos="2.22229 -3.32587 3" />
                            <Vertex pos="2.82843 -2.82842 -2.75" />
                            <Vertex pos="2.82843 -2.82842 3" />
                            <Vertex pos="3.32589 -2.22227 -2.75" />
                            <Vertex pos="3.32589 -2.22227 3" />
                            <Vertex pos="3.69552 -1.53072 -2.75" />
                            <Vertex pos="3.69552 -1.53072 3" />
                            <Vertex pos="3.92314 -0.780342 -2.75" />
                            <Vertex pos="3.92314 -0.780346 3" />
                        </Vertices>
                        <Face id="66" plane="0.995185 0.098018 0 -3.98074" album="Blasted" material="solid_bm_black" texgens="-0.0980183 0.995185 0 12.5463 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="67" plane="0.956941 0.290284 -0 -3.98074" album="Blasted" material="solid_bm_black" texgens="-0.290283 0.956941 0 37.6384 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="68" plane="0.881919 0.471401 -8.20941e-007 -3.98074" album="Blasted" material="solid_bm_black" texgens="-0.471396 0.881922 0 62.7308 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="69" plane="0.773018 0.634384 -0 -3.98074" album="Blasted" material="solid_bm_black" texgens="-0.63439 0.773013 0 87.8228 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="70" plane="0.634382 0.773019 -1.34621e-006 -3.98074" album="Blasted" material="solid_bm_black" texgens="-0.773013 0.63439 0 112.916 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="71" plane="0.4714 0.88192 -0 -3.98073" album="Blasted" material="solid_bm_black" texgens="-0.881925 0.47139 0 138.009 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="72" plane="0.29028 0.956942 -0 -3.98074" album="Blasted" material="solid_bm_black" texgens="-0.956941 0.290282 0 163.101 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="73" plane="0.0980187 0.995185 4.92992e-009 -3.98074" album="Blasted" material="solid_bm_black" texgens="-0.995185 0.0980183 0 188.193 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="74" plane="-0.0980182 0.995185 0 -3.98074" album="Blasted" material="solid_bm_black" texgens="-0.995185 -0.0980182 0 213.285 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="75" plane="-0.290293 0.956938 0 -3.98074" album="Blasted" material="solid_bm_black" texgens="-0.956938 -0.290293 0 238.379 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="76" plane="-0.471397 0.881921 0 -3.98074" album="Blasted" material="solid_bm_black" texgens="-0.881921 -0.471397 0 263.47 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="77" plane="-0.63439 0.773013 0 -3.98074" album="Blasted" material="solid_bm_black" texgens="-0.773013 -0.63439 0 288.562 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="78" plane="-0.773007 0.634398 0 -3.98074" album="Blasted" material="solid_bm_black" texgens="-0.634398 -0.773007 0 313.654 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="79" plane="-0.881919 0.471401 0 -3.98074" album="Blasted" material="solid_bm_black" texgens="-0.471401 -0.881919 0 338.748 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="80" plane="-0.956939 0.290289 -1.50457e-007 -3.98074" album="Blasted" material="solid_bm_black" texgens="-0.290291 -0.956938 0 363.839 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="81" plane="-0.995185 0.098019 -3.58011e-008 -3.98074" album="Blasted" material="solid_bm_black" texgens="-0.0980183 -0.995185 0 388.93 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 33 32 30 31" />
                        </Face>
                        <Face id="82" plane="-0.995185 -0.0980189 -1.62571e-008 -3.98074" album="Blasted" material="solid_bm_black" texgens="0.0980183 -0.995185 0 414.025 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 35 34 32 33" />
                        </Face>
                        <Face id="83" plane="-0.956942 -0.290279 0 -3.98074" album="Blasted" material="solid_bm_black" texgens="0.29028 -0.956942 0 439.115 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 37 36 34 35" />
                        </Face>
                        <Face id="84" plane="-0.881922 -0.471395 0 -3.98074" album="Blasted" material="solid_bm_black" texgens="0.471396 -0.881922 0 464.21 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 39 38 36 37" />
                        </Face>
                        <Face id="85" plane="-0.773008 -0.634396 0 -3.98074" album="Blasted" material="solid_bm_black" texgens="0.634396 -0.773008 0 489.302 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 41 40 38 39" />
                        </Face>
                        <Face id="86" plane="-0.634398 -0.773007 0 -3.98074" album="Blasted" material="solid_bm_black" texgens="0.773007 -0.634398 0 514.392 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 43 42 40 41" />
                        </Face>
                        <Face id="87" plane="-0.471395 -0.881922 0 -3.98074" album="Blasted" material="solid_bm_black" texgens="0.881922 -0.471396 0 539.487 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 45 44 42 43" />
                        </Face>
                        <Face id="88" plane="-0.290282 -0.956941 -5.11542e-008 -3.98074" album="Blasted" material="solid_bm_black" texgens="0.956941 -0.290282 0 564.578 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 47 46 44 45" />
                        </Face>
                        <Face id="89" plane="-0.0980181 -0.995185 1.64346e-009 -3.98074" album="Blasted" material="solid_bm_black" texgens="0.995185 -0.0980182 0 589.672 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 49 48 46 47" />
                        </Face>
                        <Face id="90" plane="0.0980192 -0.995184 0 -3.98074" album="Blasted" material="solid_bm_black" texgens="0.995185 0.0980183 0 614.764 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 51 50 48 49" />
                        </Face>
                        <Face id="91" plane="0.290287 -0.95694 0 -3.98074" album="Blasted" material="solid_bm_black" texgens="0.956938 0.290293 0 639.856 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 53 52 50 51" />
                        </Face>
                        <Face id="92" plane="0.471401 -0.881919 0 -3.98074" album="Blasted" material="solid_bm_black" texgens="0.881922 0.471396 0 664.949 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 55 54 52 53" />
                        </Face>
                        <Face id="93" plane="0.634396 -0.773008 0 -3.98074" album="Blasted" material="solid_bm_black" texgens="0.773008 0.634396 0 690.041 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 57 56 54 55" />
                        </Face>
                        <Face id="94" plane="0.773007 -0.634398 0 -3.98074" album="Blasted" material="solid_bm_black" texgens="0.634398 0.773007 0 715.131 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 59 58 56 57" />
                        </Face>
                        <Face id="95" plane="0.881927 -0.471385 0 -3.98074" album="Blasted" material="solid_bm_black" texgens="0.471386 0.881927 0 740.227 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 61 60 58 59" />
                        </Face>
                        <Face id="96" plane="0.956942 -0.290279 -2.01606e-007 -3.98073" album="Blasted" material="solid_bm_black" texgens="0.29028 0.956942 0 765.318 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 63 62 60 61" />
                        </Face>
                        <Face id="97" plane="0.995184 -0.0980204 -9.93374e-015 -3.98074" album="Blasted" material="solid_bm_black" texgens="0.0980207 0.995184 0 790.411 0 0 -1 -96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 63 3 2 62" />
                        </Face>
                        <Face id="98" plane="-0 0 -1 -2.75" album="Blasted" material="solid_bm_black" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 62 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28 30 32 34 36 38 40 42 44 46 48 50 52 54 56 58 60" />
                        </Face>
                        <Face id="99" plane="0 -0 1 -3" album="Blasted" material="solid_bm_black" texgens="1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 63 61 59 57 55 53 51 49 47 45 43 41 39 37 35 33 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="358" owner="0" type="0" pos="-10 119 28" rot="1 0 0 0" scale="" transform="1 0 0 -10 0 1 0 119 0 0 1 28 0 0 0 1" group="-1" locked="0" nextFaceID="133" nextVertexID="34">
                        <Vertices>
                            <Vertex pos="1.68996e-005 3.40939e-005 0.999995" />
                            <Vertex pos="3.92314 0.780365 -0.999995" />
                            <Vertex pos="4 -1.40071e-006 -0.999995" />
                            <Vertex pos="3.69552 1.53073 -0.999995" />
                            <Vertex pos="3.32588 2.22228 -0.999995" />
                            <Vertex pos="2.82843 2.82843 -0.999995" />
                            <Vertex pos="2.22228 3.32588 -0.999995" />
                            <Vertex pos="1.53072 3.69552 -0.999995" />
                            <Vertex pos="0.780348 3.92314 -0.999995" />
                            <Vertex pos="-1.04284e-005 4 -0.999995" />
                            <Vertex pos="-0.780375 3.92314 -0.999995" />
                            <Vertex pos="-1.53075 3.69551 -0.999995" />
                            <Vertex pos="-2.22226 3.32589 -0.999995" />
                            <Vertex pos="-2.82841 2.82844 -0.999995" />
                            <Vertex pos="-3.32587 2.22229 -0.999995" />
                            <Vertex pos="-3.69551 1.53075 -0.999995" />
                            <Vertex pos="-3.92314 0.780373 -0.999995" />
                            <Vertex pos="-4 9.35793e-006 -0.999995" />
                            <Vertex pos="-3.92314 -0.780351 -0.999995" />
                            <Vertex pos="-3.69552 -1.53073 -0.999995" />
                            <Vertex pos="-3.32588 -2.22228 -0.999995" />
                            <Vertex pos="-2.82843 -2.82842 -0.999995" />
                            <Vertex pos="-2.22228 -3.32588 -0.999995" />
                            <Vertex pos="-1.53073 -3.69552 -0.999995" />
                            <Vertex pos="-0.780358 -3.92314 -0.999995" />
                            <Vertex pos="3.11676e-006 -4 -0.999995" />
                            <Vertex pos="0.780367 -3.92314 -0.999995" />
                            <Vertex pos="1.53074 -3.69551 -0.999995" />
                            <Vertex pos="2.22229 -3.32587 -0.999995" />
                            <Vertex pos="2.82843 -2.82842 -0.999995" />
                            <Vertex pos="3.32589 -2.22227 -0.999995" />
                            <Vertex pos="3.69552 -1.53072 -0.999995" />
                            <Vertex pos="3.92314 -0.780345 -0.999995" />
                        </Vertices>
                        <Face id="99" plane="0.44678 0.0440043 0.893561 -0.893565" album="Blasted" material="solid_bm_black" texgens="-0.0980184 0.995185 0 12.5464 0.889258 0.0875853 -0.448943 -128.191 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="100" plane="0.429611 0.130321 0.893561 -0.893568" album="Blasted" material="solid_bm_black" texgens="-0.290282 0.956941 0 37.6382 0.855085 0.259386 -0.448941 -128.191 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 1 0" />
                        </Face>
                        <Face id="101" plane="0.395933 0.21163 0.89356 -0.89357" album="Blasted" material="solid_bm_black" texgens="-0.471397 0.881921 0 62.7311 0.788051 0.421221 -0.448941 -128.191 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 3 0" />
                        </Face>
                        <Face id="102" plane="0.347039 0.284805 0.89356 -0.893571" album="Blasted" material="solid_bm_black" texgens="-0.63439 0.773013 0 87.8228 0.690734 0.566866 -0.448942 -128.191 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0" />
                        </Face>
                        <Face id="103" plane="0.284805 0.347039 0.89356 -0.893572" album="Blasted" material="solid_bm_black" texgens="-0.773013 0.63439 0 112.916 0.566866 0.690734 -0.448942 -128.191 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 5 0" />
                        </Face>
                        <Face id="104" plane="0.211628 0.395935 0.89356 -0.893573" album="Blasted" material="solid_bm_black" texgens="-0.881926 0.471388 0 138.01 0.421216 0.788053 -0.448943 -128.191 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 0" />
                        </Face>
                        <Face id="105" plane="0.13032 0.429613 0.89356 -0.893572" album="Blasted" material="solid_bm_black" texgens="-0.956941 0.290284 0 163.101 0.259385 0.855085 -0.448942 -128.191 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 8 7 0" />
                        </Face>
                        <Face id="106" plane="0.044005 0.446782 0.89356 -0.893571" album="Blasted" material="solid_bm_black" texgens="-0.995185 0.0980179 0 188.193 0.0875852 0.889257 -0.448943 -128.191 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 9 8 0" />
                        </Face>
                        <Face id="107" plane="-0.0440046 0.446781 0.89356 -0.89357" album="Blasted" material="solid_bm_black" texgens="-0.995185 -0.0980183 0 213.285 -0.0875852 0.889258 -0.448942 -128.191 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 10 9 0" />
                        </Face>
                        <Face id="108" plane="-0.130325 0.429611 0.89356 -0.893568" album="Blasted" material="solid_bm_black" texgens="-0.956937 -0.290294 0 238.379 -0.259394 0.855081 -0.448944 -128.191 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 11 10 0" />
                        </Face>
                        <Face id="109" plane="-0.21163 0.395932 0.893561 -0.893566" album="Blasted" material="solid_bm_black" texgens="-0.881921 -0.471397 0 263.47 -0.421222 0.788051 -0.448941 -128.191 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 12 11 0" />
                        </Face>
                        <Face id="110" plane="-0.284804 0.347038 0.893561 -0.893563" album="Blasted" material="solid_bm_black" texgens="-0.773013 -0.63439 0 288.562 -0.566866 0.690734 -0.448943 -128.191 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 13 12 0" />
                        </Face>
                        <Face id="111" plane="-0.347035 0.284807 0.893561 -0.89356" album="Blasted" material="solid_bm_black" texgens="-0.634402 -0.773003 0 313.653 -0.690728 0.566872 -0.448943 -128.191 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 14 13 0" />
                        </Face>
                        <Face id="112" plane="-0.395929 0.211631 0.893562 -0.893558" album="Blasted" material="solid_bm_black" texgens="-0.471398 -0.881921 0 338.748 -0.788049 0.421225 -0.448942 -128.191 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 15 14 0" />
                        </Face>
                        <Face id="113" plane="-0.429608 0.130323 0.893562 -0.893555" album="Blasted" material="solid_bm_black" texgens="-0.290286 -0.95694 0 363.84 -0.855083 0.259393 -0.448941 -128.191 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 16 15 0" />
                        </Face>
                        <Face id="114" plane="-0.446777 0.0440042 0.893562 -0.893552" album="Blasted" material="solid_bm_black" texgens="-0.0980179 -0.995185 0 388.931 -0.889258 0.0875853 -0.448942 -128.191 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 17 16 0" />
                        </Face>
                        <Face id="115" plane="-0.446777 -0.0440043 0.893563 -0.893549" album="Blasted" material="solid_bm_black" texgens="0.0980183 -0.995185 0 414.025 -0.889257 -0.0875852 -0.448943 -128.191 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 18 17 0" />
                        </Face>
                        <Face id="116" plane="-0.429608 -0.130317 0.893563 -0.893547" album="Blasted" material="solid_bm_black" texgens="0.29028 -0.956942 0 439.115 -0.855086 -0.259383 -0.448941 -128.191 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 19 18 0" />
                        </Face>
                        <Face id="117" plane="-0.395928 -0.211627 0.893563 -0.893545" album="Blasted" material="solid_bm_black" texgens="0.471397 -0.881921 0 464.21 -0.788051 -0.421221 -0.448941 -128.191 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 20 19 0" />
                        </Face>
                        <Face id="118" plane="-0.347032 -0.284804 0.893563 -0.893543" album="Blasted" material="solid_bm_black" texgens="0.634397 -0.773008 0 489.302 -0.690731 -0.566873 -0.448939 -128.191 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 21 20 0" />
                        </Face>
                        <Face id="119" plane="-0.284805 -0.347032 0.893563 -0.893542" album="Blasted" material="solid_bm_black" texgens="0.773003 -0.634402 0 514.391 -0.566872 -0.690728 -0.448943 -128.191 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 22 21 0" />
                        </Face>
                        <Face id="120" plane="-0.211627 -0.395927 0.893563 -0.893542" album="Blasted" material="solid_bm_black" texgens="0.881921 -0.471397 0 539.487 -0.421221 -0.788051 -0.448941 -128.191 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 23 22 0" />
                        </Face>
                        <Face id="121" plane="-0.130318 -0.429606 0.893563 -0.893542" album="Blasted" material="solid_bm_black" texgens="0.956941 -0.290284 0 564.578 -0.259385 -0.855086 -0.448941 -128.191 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 24 23 0" />
                        </Face>
                        <Face id="122" plane="-0.0440042 -0.446775 0.893563 -0.893543" album="Blasted" material="solid_bm_black" texgens="0.995185 -0.0980179 0 589.673 -0.0875852 -0.889258 -0.448942 -128.191 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 25 24 0" />
                        </Face>
                        <Face id="123" plane="0.044004 -0.446776 0.893563 -0.893544" album="Blasted" material="solid_bm_black" texgens="0.995185 0.0980183 0 614.764 0.0875853 -0.889258 -0.448942 -128.191 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 26 25 0" />
                        </Face>
                        <Face id="124" plane="0.130324 -0.429606 0.893563 -0.893546" album="Blasted" material="solid_bm_black" texgens="0.956938 0.290291 0 639.856 0.259394 -0.855083 -0.448941 -128.191 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 27 26 0" />
                        </Face>
                        <Face id="125" plane="0.211628 -0.395929 0.893563 -0.893548" album="Blasted" material="solid_bm_black" texgens="0.881921 0.471397 0 664.949 0.421221 -0.788051 -0.448942 -128.191 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 28 27 0" />
                        </Face>
                        <Face id="126" plane="0.284805 -0.347034 0.893562 -0.893551" album="Blasted" material="solid_bm_black" texgens="0.773007 0.634397 0 690.041 0.566873 -0.690731 -0.448939 -128.191 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 29 28 0" />
                        </Face>
                        <Face id="127" plane="0.347033 -0.284806 0.893562 -0.893554" album="Blasted" material="solid_bm_black" texgens="0.634402 0.773003 0 715.13 0.690728 -0.566873 -0.448943 -128.191 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 30 29 0" />
                        </Face>
                        <Face id="128" plane="0.395933 -0.211624 0.893562 -0.893557" album="Blasted" material="solid_bm_black" texgens="0.471387 0.881926 0 740.227 0.788055 -0.421211 -0.448944 -128.191 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 30 0" />
                        </Face>
                        <Face id="129" plane="0.429611 -0.130319 0.893561 -0.89356" album="Blasted" material="solid_bm_black" texgens="0.290283 0.956941 0 765.317 0.855086 -0.259383 -0.448941 -128.191 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 32 31 0" />
                        </Face>
                        <Face id="130" plane="0.44678 -0.0440055 0.893561 -0.893563" album="Blasted" material="solid_bm_black" texgens="0.0980204 0.995184 0 790.411 0.889258 -0.0875874 -0.448942 -128.191 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 32 0 2" />
                        </Face>
                        <Face id="131" plane="-0 0 -1 -0.999995" album="Blasted" material="solid_bm_black" texgens="-1 0 0 0.500008 0 -1 0 0.499992 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 32 2 1 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31" />
                        </Face>
                    </Brush>
                    <Brush id="361" owner="0" type="0" pos="-10 119 19.25" rot="1 0 0 0" scale="" transform="1 0 0 -10 0 -1 8.74228e-008 119 0 -8.74228e-008 -1 19.25 0 0 0 1" group="-1" locked="0" nextFaceID="101" nextVertexID="65">
                        <Vertices>
                            <Vertex pos="3.92314 -0.780343 -1.99999" />
                            <Vertex pos="4 -3.12924e-006 -1.99999" />
                            <Vertex pos="3.92314 0.780366 -1.99998" />
                            <Vertex pos="3.69552 1.53073 -1.99998" />
                            <Vertex pos="3.32588 2.22228 -1.99999" />
                            <Vertex pos="2.82843 2.82843 -1.99998" />
                            <Vertex pos="2.22228 3.32588 -1.99998" />
                            <Vertex pos="1.53072 3.69552 -1.99999" />
                            <Vertex pos="0.780347 3.92314 -1.99998" />
                            <Vertex pos="-1.37266e-005 4 -1.99999" />
                            <Vertex pos="-0.780376 3.92314 -1.99998" />
                            <Vertex pos="-1.53075 3.69551 -1.99998" />
                            <Vertex pos="-2.22226 3.32589 -1.99999" />
                            <Vertex pos="-2.82841 2.82844 -1.99999" />
                            <Vertex pos="-3.32587 2.22229 -1.99998" />
                            <Vertex pos="-3.69551 1.53075 -1.99998" />
                            <Vertex pos="-3.92314 0.780372 -1.99999" />
                            <Vertex pos="-4 1.09076e-005 -1.99999" />
                            <Vertex pos="-3.92314 -0.780356 -1.99999" />
                            <Vertex pos="-3.69552 -1.53073 -1.99998" />
                            <Vertex pos="-3.32588 -2.22228 -1.99999" />
                            <Vertex pos="-2.82843 -2.82842 -1.99998" />
                            <Vertex pos="-2.22228 -3.32588 -1.99999" />
                            <Vertex pos="-1.53073 -3.69552 -1.99998" />
                            <Vertex pos="-0.780361 -3.92314 -1.99999" />
                            <Vertex pos="1.50135e-006 -4 -1.99999" />
                            <Vertex pos="0.78037 -3.92314 -1.99999" />
                            <Vertex pos="1.53074 -3.69551 -1.99999" />
                            <Vertex pos="2.22229 -3.32587 -1.99998" />
                            <Vertex pos="2.82843 -2.82842 -1.99999" />
                            <Vertex pos="3.32589 -2.22227 -1.99998" />
                            <Vertex pos="3.69552 -1.53072 -1.99999" />
                            <Vertex pos="3.75 -4.7386e-006 -1.74998" />
                            <Vertex pos="3.67794 0.73159 -1.74998" />
                            <Vertex pos="3.46455 1.43505 -1.74998" />
                            <Vertex pos="3.11801 2.08338 -1.74998" />
                            <Vertex pos="2.65165 2.65165 -1.74998" />
                            <Vertex pos="2.08339 3.11801 -1.74998" />
                            <Vertex pos="1.43505 3.46454 -1.74998" />
                            <Vertex pos="0.731577 3.67794 -1.74998" />
                            <Vertex pos="-1.08547e-005 3.74999 -1.74998" />
                            <Vertex pos="-0.731599 3.67794 -1.74998" />
                            <Vertex pos="-1.43507 3.46453 -1.74998" />
                            <Vertex pos="-2.08336 3.11802 -1.74998" />
                            <Vertex pos="-2.65163 2.65166 -1.74998" />
                            <Vertex pos="-3.118 2.08339 -1.74998" />
                            <Vertex pos="-3.46453 1.43507 -1.74998" />
                            <Vertex pos="-3.67794 0.731596 -1.74998" />
                            <Vertex pos="-3.74999 8.42097e-006 -1.74998" />
                            <Vertex pos="-3.67794 -0.731584 -1.74998" />
                            <Vertex pos="-3.46454 -1.43506 -1.74998" />
                            <Vertex pos="-3.11801 -2.08339 -1.74998" />
                            <Vertex pos="-2.65165 -2.65164 -1.74998" />
                            <Vertex pos="-2.08339 -3.11801 -1.74998" />
                            <Vertex pos="-1.43505 -3.46455 -1.74998" />
                            <Vertex pos="-0.731585 -3.67794 -1.74998" />
                            <Vertex pos="3.42151e-006 -3.75 -1.74998" />
                            <Vertex pos="0.731597 -3.67794 -1.74998" />
                            <Vertex pos="1.43507 -3.46454 -1.74998" />
                            <Vertex pos="2.0834 -3.118 -1.74998" />
                            <Vertex pos="2.65165 -2.65164 -1.74998" />
                            <Vertex pos="3.11802 -2.08338 -1.74998" />
                            <Vertex pos="3.46455 -1.43505 -1.74998" />
                            <Vertex pos="3.67794 -0.731572 -1.74998" />
                        </Vertices>
                        <Face id="66" plane="-6.51405e-005 6.41605e-006 -1 -1.99973" album="Blasted" material="solid_bm_black" texgens="-1 0 0 0.5 0 -1 0 0.499989 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31" />
                        </Face>
                        <Face id="67" plane="0.705412 0.0694812 0.705384 -1.41089" album="Blasted" material="solid_bm_black" texgens="-0.0980181 0.995185 0 12.5463 0.702002 0.069142 -0.708811 -135.22 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 32 33 2" />
                        </Face>
                        <Face id="68" plane="0.678284 0.205755 0.705405 -1.41077" album="Blasted" material="solid_bm_black" texgens="-0.290283 0.956941 0 37.6384 0.675024 0.204765 -0.708811 -135.22 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 33 34" />
                        </Face>
                        <Face id="69" plane="0.625107 0.334136 0.705404 -1.41077" album="Blasted" material="solid_bm_black" texgens="-0.471396 0.881922 0 62.7309 0.622106 0.332521 -0.708812 -135.22 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 3 34 35" />
                        </Face>
                        <Face id="70" plane="0.547929 0.449658 0.705394 -1.41083" album="Blasted" material="solid_bm_black" texgens="-0.63439 0.773013 0 87.8228 0.545282 0.447498 -0.708811 -135.22 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 35 36" />
                        </Face>
                        <Face id="71" plane="0.449659 0.547915 0.705405 -1.41077" album="Blasted" material="solid_bm_black" texgens="-0.773013 0.63439 0 112.916 0.447498 0.545283 -0.70881 -135.22 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 5 36 37" />
                        </Face>
                        <Face id="72" plane="0.334118 0.625122 0.705399 -1.4108" album="Blasted" material="solid_bm_black" texgens="-0.881925 0.47139 0 138.009 0.332518 0.622108 -0.708811 -135.22 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 37 38" />
                        </Face>
                        <Face id="73" plane="0.205763 0.678289 0.705398 -1.41081" album="Blasted" material="solid_bm_black" texgens="-0.956941 0.290282 0 163.101 0.204764 0.675024 -0.708812 -135.22 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 8 7 38 39" />
                        </Face>
                        <Face id="74" plane="0.0694672 0.705394 0.705403 -1.41078" album="Blasted" material="solid_bm_black" texgens="-0.995185 0.0980181 0 188.193 0.0691419 0.702002 -0.708811 -135.22 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 9 8 39 40" />
                        </Face>
                        <Face id="75" plane="-0.0694675 0.705398 0.705399 -1.4108" album="Blasted" material="solid_bm_black" texgens="-0.995185 -0.0980182 0 213.285 -0.069142 0.702002 -0.70881 -135.22 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 10 9 40 41" />
                        </Face>
                        <Face id="76" plane="-0.205761 0.678282 0.705405 -1.41077" album="Blasted" material="solid_bm_black" texgens="-0.956938 -0.290293 0 238.379 -0.204772 0.675022 -0.708812 -135.22 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 11 10 41 42" />
                        </Face>
                        <Face id="77" plane="-0.334131 0.625095 0.705416 -1.4107" album="Blasted" material="solid_bm_black" texgens="-0.881921 -0.471397 0 263.47 -0.332522 0.622105 -0.708812 -135.22 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 12 11 42 43" />
                        </Face>
                        <Face id="78" plane="-0.449666 0.547924 0.705394 -1.41083" album="Blasted" material="solid_bm_black" texgens="-0.773013 -0.63439 0 288.562 -0.447498 0.545282 -0.708811 -135.22 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 13 12 43 44" />
                        </Face>
                        <Face id="79" plane="-0.547916 0.44968 0.705391 -1.41085" album="Blasted" material="solid_bm_black" texgens="-0.634397 -0.773007 0 313.654 -0.545278 0.447503 -0.708811 -135.22 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 14 13 44 45" />
                        </Face>
                        <Face id="80" plane="-0.625107 0.33413 0.705407 -1.41076" album="Blasted" material="solid_bm_black" texgens="-0.4714 -0.881919 0 338.748 -0.622104 0.332525 -0.708811 -135.22 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 15 14 45 46" />
                        </Face>
                        <Face id="81" plane="-0.678275 0.205748 0.705415 -1.4107" album="Blasted" material="solid_bm_black" texgens="-0.290292 -0.956938 0 363.839 -0.675022 0.204771 -0.708812 -135.22 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 16 15 46 47" />
                        </Face>
                        <Face id="82" plane="-0.705406 0.0694774 0.70539 -1.41085" album="Blasted" material="solid_bm_black" texgens="-0.0980181 -0.995185 0 388.931 -0.702002 0.069142 -0.708811 -135.22 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 17 16 47 48" />
                        </Face>
                        <Face id="83" plane="-0.705398 -0.0694762 0.705398 -1.4108" album="Blasted" material="solid_bm_black" texgens="0.0980181 -0.995185 0 414.025 -0.702002 -0.0691419 -0.708811 -135.22 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 18 17 48 49" />
                        </Face>
                        <Face id="84" plane="-0.678302 -0.205748 0.705389 -1.41086" album="Blasted" material="solid_bm_black" texgens="0.29028 -0.956942 0 439.115 -0.675025 -0.204763 -0.708812 -135.22 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 19 18 49 50" />
                        </Face>
                        <Face id="85" plane="-0.625102 -0.334133 0.70541 -1.41074" album="Blasted" material="solid_bm_black" texgens="0.471396 -0.881922 0 464.21 -0.622106 -0.332521 -0.708812 -135.22 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 20 19 50 51" />
                        </Face>
                        <Face id="86" plane="-0.547933 -0.449669 0.705385 -1.41089" album="Blasted" material="solid_bm_black" texgens="0.634396 -0.773008 0 489.302 -0.545279 -0.447502 -0.708811 -135.22 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 21 20 51 52" />
                        </Face>
                        <Face id="87" plane="-0.449657 -0.547917 0.705405 -1.41077" album="Blasted" material="solid_bm_black" texgens="0.773007 -0.634397 0 514.392 -0.447503 -0.545278 -0.708811 -135.22 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 22 21 52 53" />
                        </Face>
                        <Face id="88" plane="-0.334144 -0.625123 0.705386 -1.41088" album="Blasted" material="solid_bm_black" texgens="0.881922 -0.471396 0 539.487 -0.332521 -0.622106 -0.708812 -135.22 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 23 22 53 54" />
                        </Face>
                        <Face id="89" plane="-0.205746 -0.67829 0.705401 -1.41079" album="Blasted" material="solid_bm_black" texgens="0.956941 -0.290282 0 564.578 -0.204765 -0.675024 -0.708811 -135.22 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 24 23 54 55" />
                        </Face>
                        <Face id="90" plane="-0.0694773 -0.705406 0.70539 -1.41085" album="Blasted" material="solid_bm_black" texgens="0.995185 -0.098018 0 589.673 -0.0691419 -0.702002 -0.708811 -135.22 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 25 24 55 56" />
                        </Face>
                        <Face id="91" plane="0.0694774 -0.705412 0.705384 -1.41089" album="Blasted" material="solid_bm_black" texgens="0.995185 0.0980181 0 614.764 0.069142 -0.702002 -0.708811 -135.22 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 26 25 56 57" />
                        </Face>
                        <Face id="92" plane="0.205766 -0.678297 0.705389 -1.41086" album="Blasted" material="solid_bm_black" texgens="0.956938 0.290293 0 639.856 0.204772 -0.675021 -0.708812 -135.22 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 27 26 57 58" />
                        </Face>
                        <Face id="93" plane="0.334129 -0.625133 0.705384 -1.41089" album="Blasted" material="solid_bm_black" texgens="0.881922 0.471396 0 664.949 0.332521 -0.622105 -0.708812 -135.22 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 28 27 58 59" />
                        </Face>
                        <Face id="94" plane="0.449674 -0.547911 0.705398 -1.41081" album="Blasted" material="solid_bm_black" texgens="0.773008 0.634396 0 690.041 0.447502 -0.545278 -0.708811 -135.22 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 29 28 59 60" />
                        </Face>
                        <Face id="95" plane="0.547916 -0.44968 0.705391 -1.41085" album="Blasted" material="solid_bm_black" texgens="0.634397 0.773007 0 715.131 0.545278 -0.447503 -0.708811 -135.22 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 30 29 60 61" />
                        </Face>
                        <Face id="96" plane="0.625124 -0.334115 0.705399 -1.4108" album="Blasted" material="solid_bm_black" texgens="0.471386 0.881927 0 740.227 0.622109 -0.332514 -0.708812 -135.22 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 30 61 62" />
                        </Face>
                        <Face id="97" plane="0.678305 -0.205758 0.705383 -1.41089" album="Blasted" material="solid_bm_black" texgens="0.29028 0.956942 0 765.318 0.675024 -0.204763 -0.708812 -135.22 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 31 62 63" />
                        </Face>
                        <Face id="98" plane="0.705406 -0.0694832 0.705389 -1.41086" album="Blasted" material="solid_bm_black" texgens="0.0980206 0.995184 0 790.411 0.702002 -0.0691436 -0.708811 -135.22 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 63 32 1" />
                        </Face>
                        <Face id="99" plane="0 -0 1 1.74998" album="Blasted" material="solid_bm_black" texgens="0 -1 0 12.5463 1 0 0 -135.22 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 63 62 61 60 59 58 57 56 55 54 53 52 51 50 49 48 47 46 45 44 43 42 41 40 39 38 37 36 35 34 33 32" />
                        </Face>
                    </Brush>
                    <Brush id="362" owner="0" type="0" pos="21.5 -82.875 20.75" rot="1 0 0 0" scale="" transform="1 0 0 21.5 0 1 0 -82.875 0 0 1 20.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.75 0.125 0.25" />
                            <Vertex pos="6.75 0.125 -0.25" />
                            <Vertex pos="6.75 -0.125 0.25" />
                            <Vertex pos="6.75 -0.125 -0.25" />
                            <Vertex pos="2.25 0.125 0.25" />
                            <Vertex pos="2.25 0.125 -0.25" />
                            <Vertex pos="2.25 -0.125 0.25" />
                            <Vertex pos="2.25 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.75" album="Blasted" material="bm_trim" texgens="0 1 0 -21216 0 0 -1 -5312 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.25" album="Blasted" material="bm_trim" texgens="0 -1 0 21216 0 0 -1 -5312 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_trim" texgens="-1 0 0 -5504 0 0 -1 -5312 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="Blasted" material="bm_trim" texgens="1 0 0 5504 0 0 -1 -5312 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 5504 0 -1 0 21216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 -5504 0 -1 0 21216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="365" owner="0" type="0" pos="28.125 -85 20.75" rot="1 0 0 0" scale="" transform="1 0 0 28.125 0 1 0 -85 0 0 1 20.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 2 0.25" />
                            <Vertex pos="0.125 2 -0.25" />
                            <Vertex pos="0.125 -10 0.25" />
                            <Vertex pos="0.125 -10 -0.25" />
                            <Vertex pos="-0.125 2 0.25" />
                            <Vertex pos="-0.125 2 -0.25" />
                            <Vertex pos="-0.125 -10 0.25" />
                            <Vertex pos="-0.125 -10 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white" texgens="0 1 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white" texgens="0 -1 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -10" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublevert" texgens="1 0 0 32 0 -1 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 -1 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="366" owner="0" type="0" pos="28.125 -95.125 20.75" rot="1 0 0 0" scale="" transform="1 0 0 28.125 0 1 0 -95.125 0 0 1 20.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.125 0.25" />
                            <Vertex pos="0.125 0.125 -0.25" />
                            <Vertex pos="0.125 -0.125 0.25" />
                            <Vertex pos="0.125 -0.125 -0.25" />
                            <Vertex pos="-0.125 0.125 0.25" />
                            <Vertex pos="-0.125 0.125 -0.25" />
                            <Vertex pos="-0.125 -0.125 0.25" />
                            <Vertex pos="-0.125 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white_doublevert" texgens="0 1 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -288 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_half" texgens="1 0 0 32 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="64 64">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_half" texgens="-1 0 0 96 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="64 64">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="367" owner="0" type="0" pos="-52 15 20.25" rot="1 0 0 0" scale="" transform="1 0 0 -52 0 1 0 15 0 0 1 20.25 0 0 0 1" group="-1" locked="0" nextFaceID="105" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="1.84776 0.765367 -1.25" />
                            <Vertex pos="1.84776 0.765366 1.5" />
                            <Vertex pos="2 0 -1.25" />
                            <Vertex pos="2 1.78814e-007 1.5" />
                            <Vertex pos="1.41421 1.41421 -1.25" />
                            <Vertex pos="1.41421 1.41421 1.5" />
                            <Vertex pos="0.765362 1.84776 -1.25" />
                            <Vertex pos="0.765363 1.84776 1.5" />
                            <Vertex pos="-7.62939e-006 2 -1.25" />
                            <Vertex pos="-8.06288e-006 2 1.5" />
                            <Vertex pos="-0.765377 1.84776 -1.25" />
                            <Vertex pos="-0.765375 1.84776 1.5" />
                            <Vertex pos="-1.41421 1.41422 -1.25" />
                            <Vertex pos="-1.41421 1.41422 1.5" />
                            <Vertex pos="-1.84776 0.765375 -1.25" />
                            <Vertex pos="-1.84776 0.765376 1.5" />
                            <Vertex pos="-2 4.76837e-006 -1.25" />
                            <Vertex pos="-2 5.06723e-006 1.5" />
                            <Vertex pos="-1.84776 -0.765366 -1.25" />
                            <Vertex pos="-1.84776 -0.765365 1.5" />
                            <Vertex pos="-1.41421 -1.41421 -1.25" />
                            <Vertex pos="-1.41421 -1.41421 1.5" />
                            <Vertex pos="-0.765366 -1.84776 -1.25" />
                            <Vertex pos="-0.765365 -1.84776 1.5" />
                            <Vertex pos="0 -2 -1.25" />
                            <Vertex pos="7.97368e-007 -2 1.5" />
                            <Vertex pos="0.765373 -1.84776 -1.25" />
                            <Vertex pos="0.765372 -1.84776 1.5" />
                            <Vertex pos="1.41422 -1.41421 -1.25" />
                            <Vertex pos="1.41422 -1.41421 1.5" />
                            <Vertex pos="1.84776 -0.76536 -1.25" />
                            <Vertex pos="1.84776 -0.76536 1.5" />
                        </Vertices>
                        <Face id="86" plane="0.980785 0.195089 6.76552e-008 -1.96157" album="Blasted" material="metal_bm" texgens="-0.195089 0.980786 0 12.4857 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="87" plane="0.831465 0.555576 -0 -1.96157" album="Blasted" material="metal_bm" texgens="-0.555576 0.831465 0 37.4578 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="88" plane="0.555574 0.831467 -1.92668e-007 -1.96157" album="Blasted" material="metal_bm" texgens="-0.831468 0.555573 0 62.4285 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="89" plane="0.195089 0.980786 3.07523e-008 -1.96157" album="Blasted" material="metal_bm" texgens="-0.980786 0.195089 0 87.4006 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="90" plane="-0.195089 0.980786 1.39538e-007 -1.96157" album="Blasted" material="metal_bm" texgens="-0.980786 -0.195089 0 112.372 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="91" plane="-0.555574 0.831467 0 -1.96158" album="Blasted" material="metal_bm" texgens="-0.831468 -0.555572 0 137.344 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="92" plane="-0.831466 0.555575 -1.92668e-007 -1.96157" album="Blasted" material="metal_bm" texgens="-0.555575 -0.831467 0 162.315 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="93" plane="-0.980786 0.195088 -2.12015e-008 -1.96157" album="Blasted" material="metal_bm" texgens="-0.195089 -0.980786 0 187.287 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="94" plane="-0.980786 -0.195088 7.18832e-008 -1.96157" album="Blasted" material="metal_bm" texgens="0.195089 -0.980786 0 212.258 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="95" plane="-0.831466 -0.555576 0 -1.96157" album="Blasted" material="metal_bm" texgens="0.555575 -0.831467 0 237.23 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="96" plane="-0.555576 -0.831466 2.0471e-007 -1.96157" album="Blasted" material="metal_bm" texgens="0.831466 -0.555576 0 262.201 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="97" plane="-0.195089 -0.980785 5.65666e-008 -1.96157" album="Blasted" material="metal_bm" texgens="0.980786 -0.195089 0 287.173 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="98" plane="0.195088 -0.980786 7.1883e-008 -1.96157" album="Blasted" material="metal_bm" texgens="0.980786 0.195089 0 312.145 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="99" plane="0.555574 -0.831467 0 -1.96157" album="Blasted" material="metal_bm" texgens="0.831468 0.555573 0 337.116 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="100" plane="0.831474 -0.555563 0 -1.96157" album="Blasted" material="metal_bm" texgens="0.555563 0.831474 0 362.089 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="101" plane="0.980785 -0.195091 1.26854e-008 -1.96157" album="Blasted" material="metal_bm" texgens="0.195091 0.980785 0 387.058 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 3 2 30" />
                        </Face>
                        <Face id="102" plane="-0 0 -1 -1.25" album="Blasted" material="metal_bm" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 30 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28" />
                        </Face>
                        <Face id="103" plane="0 -0 1 -1.5" album="Blasted" material="metal_bm" texgens="1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="368" owner="0" type="0" pos="-52 15 22.25" rot="1 0 0 0" scale="" transform="1 0 0 -52 0 1 0 15 0 0 1 22.25 0 0 0 1" group="-1" locked="0" nextFaceID="86" nextVertexID="18">
                        <Vertices>
                            <Vertex pos="-8.32988e-007 2.32458e-006 0.5" />
                            <Vertex pos="1.84776 0.765367 -0.5" />
                            <Vertex pos="2 -1.49012e-006 -0.5" />
                            <Vertex pos="1.41421 1.41421 -0.5" />
                            <Vertex pos="0.765363 1.84776 -0.5" />
                            <Vertex pos="-8.91321e-006 2 -0.5" />
                            <Vertex pos="-0.765374 1.84776 -0.5" />
                            <Vertex pos="-1.41421 1.41422 -0.5" />
                            <Vertex pos="-1.84776 0.765374 -0.5" />
                            <Vertex pos="-2 4.76837e-006 -0.5" />
                            <Vertex pos="-1.84776 -0.765364 -0.5" />
                            <Vertex pos="-1.41421 -1.41421 -0.5" />
                            <Vertex pos="-0.765367 -1.84776 -0.5" />
                            <Vertex pos="1.34539e-006 -2 -0.5" />
                            <Vertex pos="0.765371 -1.84776 -0.5" />
                            <Vertex pos="1.41422 -1.41421 -0.5" />
                            <Vertex pos="1.84776 -0.765358 -0.5" />
                        </Vertices>
                        <Face id="68" plane="0.445455 0.0886056 0.890909 -0.445454" album="Blasted" material="metal_bm" texgens="-0.195089 0.980786 0 12.4857 0.873791 0.173807 -0.454181 -63.1895 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="69" plane="0.377637 0.252333 0.890909 -0.445455" album="Blasted" material="metal_bm" texgens="-0.555577 0.831465 0 37.4579 0.74076 0.494968 -0.454181 -63.1894 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 1 0" />
                        </Face>
                        <Face id="70" plane="0.252332 0.377638 0.890909 -0.445455" album="Blasted" material="metal_bm" texgens="-0.831471 0.555568 0 62.429 0.494965 0.740761 -0.454184 -63.1894 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 3 0" />
                        </Face>
                        <Face id="71" plane="0.0886055 0.445455 0.890909 -0.445455" album="Blasted" material="metal_bm" texgens="-0.980785 0.195089 0 87.4006 0.173806 0.873791 -0.454181 -63.1895 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0" />
                        </Face>
                        <Face id="72" plane="-0.0886061 0.445455 0.890909 -0.445456" album="Blasted" material="metal_bm" texgens="-0.980786 -0.195089 0 112.372 -0.173807 0.873791 -0.454181 -63.1896 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 5 0" />
                        </Face>
                        <Face id="73" plane="-0.25233 0.377637 0.890909 -0.445456" album="Blasted" material="metal_bm" texgens="-0.831468 -0.555572 0 137.344 -0.494965 0.740763 -0.454181 -63.1896 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 0" />
                        </Face>
                        <Face id="74" plane="-0.377637 0.252332 0.890909 -0.445456" album="Blasted" material="metal_bm" texgens="-0.555568 -0.831471 0 162.315 -0.740761 0.494966 -0.454182 -63.1896 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 8 7 0" />
                        </Face>
                        <Face id="75" plane="-0.445455 0.0886056 0.890909 -0.445455" album="Blasted" material="metal_bm" texgens="-0.195089 -0.980785 0 187.287 -0.873791 0.173806 -0.454181 -63.1895 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 9 8 0" />
                        </Face>
                        <Face id="76" plane="-0.445455 -0.0886057 0.890909 -0.445455" album="Blasted" material="metal_bm" texgens="0.195089 -0.980786 0 212.258 -0.873791 -0.173806 -0.454181 -63.1895 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 10 9 0" />
                        </Face>
                        <Face id="77" plane="-0.377637 -0.252332 0.890909 -0.445454" album="Blasted" material="metal_bm" texgens="0.555575 -0.831466 0 237.23 -0.740761 -0.494966 -0.454182 -63.1894 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 11 10 0" />
                        </Face>
                        <Face id="78" plane="-0.252333 -0.377636 0.890909 -0.445454" album="Blasted" material="metal_bm" texgens="0.831462 -0.555582 0 262.2 -0.494968 -0.740761 -0.454179 -63.1895 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 12 11 0" />
                        </Face>
                        <Face id="79" plane="-0.0886057 -0.445454 0.890909 -0.445454" album="Blasted" material="metal_bm" texgens="0.980785 -0.195089 0 287.173 -0.173807 -0.873791 -0.454181 -63.1895 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 13 12 0" />
                        </Face>
                        <Face id="80" plane="0.0886055 -0.445454 0.890909 -0.445454" album="Blasted" material="metal_bm" texgens="0.980786 0.195088 0 312.144 0.173806 -0.873791 -0.454181 -63.1895 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 14 13 0" />
                        </Face>
                        <Face id="81" plane="0.252331 -0.377637 0.890909 -0.445454" album="Blasted" material="metal_bm" texgens="0.831467 0.555574 0 337.116 0.494965 -0.740763 -0.45418 -63.1896 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 15 14 0" />
                        </Face>
                        <Face id="82" plane="0.37764 -0.252326 0.890909 -0.445454" album="Blasted" material="metal_bm" texgens="0.555566 0.831472 0 362.089 0.740767 -0.494956 -0.454184 -63.1895 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 16 15 0" />
                        </Face>
                        <Face id="83" plane="0.445454 -0.088607 0.890909 -0.445454" album="Blasted" material="metal_bm" texgens="0.195092 0.980785 0 387.058 0.873791 -0.173808 -0.454181 -63.1895 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 16 0 2" />
                        </Face>
                        <Face id="84" plane="-0 0 -1 -0.5" album="Blasted" material="metal_bm" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 16 2 1 3 4 5 6 7 8 9 10 11 12 13 14 15" />
                        </Face>
                    </Brush>
                    <Brush id="370" owner="0" type="0" pos="-52 15 18" rot="1 0 0 0" scale="" transform="1 0 0 -52 0 -1 8.74228e-008 15 0 -8.74228e-008 -1 18 0 0 0 1" group="-1" locked="0" nextFaceID="36" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="1.84776 -0.765361 -1" />
                            <Vertex pos="2 1.19209e-007 -1" />
                            <Vertex pos="1.84776 0.765367 -1" />
                            <Vertex pos="1.41421 1.41421 -1" />
                            <Vertex pos="0.765362 1.84776 -1" />
                            <Vertex pos="-6.89454e-006 2 -1" />
                            <Vertex pos="-0.765376 1.84776 -1" />
                            <Vertex pos="-1.41421 1.41422 -1" />
                            <Vertex pos="-1.84776 0.765374 -1" />
                            <Vertex pos="-2 4.88758e-006 -1" />
                            <Vertex pos="-1.84776 -0.765363 -1" />
                            <Vertex pos="-1.41421 -1.41421 -1" />
                            <Vertex pos="-0.765366 -1.84776 -1" />
                            <Vertex pos="1.34345e-006 -2 -1" />
                            <Vertex pos="0.765371 -1.84776 -1" />
                            <Vertex pos="1.41422 -1.41421 -1" />
                            <Vertex pos="1.75001 5.9606e-008 -0.750006" />
                            <Vertex pos="1.6168 0.669698 -0.750006" />
                            <Vertex pos="1.23744 1.23744 -0.750007" />
                            <Vertex pos="0.669694 1.6168 -0.750007" />
                            <Vertex pos="-6.17804e-006 1.75001 -0.750007" />
                            <Vertex pos="-0.669706 1.6168 -0.750007" />
                            <Vertex pos="-1.23744 1.23745 -0.750007" />
                            <Vertex pos="-1.6168 0.669705 -0.750006" />
                            <Vertex pos="-1.75001 4.23194e-006 -0.750006" />
                            <Vertex pos="-1.6168 -0.669695 -0.750006" />
                            <Vertex pos="-1.23744 -1.23744 -0.750006" />
                            <Vertex pos="-0.669697 -1.6168 -0.750006" />
                            <Vertex pos="1.03023e-006 -1.75001 -0.750006" />
                            <Vertex pos="0.669702 -1.61679 -0.750006" />
                            <Vertex pos="1.23745 -1.23744 -0.750006" />
                            <Vertex pos="1.6168 -0.669693 -0.750006" />
                        </Vertices>
                        <Face id="17" plane="-0 0 -1 -1" album="Blasted" material="metal_bm" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15" />
                        </Face>
                        <Face id="18" plane="0.70022 0.139281 0.700209 -0.700231" album="Blasted" material="metal_bm" texgens="-0.195089 0.980785 0 12.4857 0.68676 0.136604 -0.713933 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 16 17 2" />
                        </Face>
                        <Face id="19" plane="0.593615 0.396647 0.700209 -0.700229" album="Blasted" material="metal_bm" texgens="-0.555576 0.831466 0 37.4578 0.582204 0.389023 -0.713933 -66.7984 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 17 18" />
                        </Face>
                        <Face id="20" plane="0.396644 0.593614 0.700211 -0.700222" album="Blasted" material="metal_bm" texgens="-0.831467 0.555574 0 62.4285 0.38902 0.582205 -0.713933 -66.7984 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 3 18 19" />
                        </Face>
                        <Face id="21" plane="0.139281 0.70022 0.700209 -0.700229" album="Blasted" material="metal_bm" texgens="-0.980786 0.195089 0 87.4006 0.136604 0.68676 -0.713933 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 19 20" />
                        </Face>
                        <Face id="22" plane="-0.139281 0.700219 0.70021 -0.700228" album="Blasted" material="metal_bm" texgens="-0.980785 -0.195089 0 112.372 -0.136604 0.68676 -0.713933 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 5 20 21" />
                        </Face>
                        <Face id="23" plane="-0.396643 0.593614 0.700212 -0.700226" album="Blasted" material="metal_bm" texgens="-0.831468 -0.555573 0 137.344 -0.38902 0.582206 -0.713932 -66.7986 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 21 22" />
                        </Face>
                        <Face id="24" plane="-0.593614 0.396645 0.700211 -0.700226" album="Blasted" material="metal_bm" texgens="-0.555575 -0.831467 0 162.315 -0.582205 0.389022 -0.713932 -66.7986 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 8 7 22 23" />
                        </Face>
                        <Face id="25" plane="-0.700221 0.139281 0.700208 -0.700234" album="Blasted" material="metal_bm" texgens="-0.195089 -0.980785 0 187.287 -0.68676 0.136604 -0.713932 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 9 8 23 24" />
                        </Face>
                        <Face id="26" plane="-0.70022 -0.139281 0.700209 -0.700231" album="Blasted" material="metal_bm" texgens="0.195089 -0.980786 0 212.258 -0.68676 -0.136604 -0.713933 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 10 9 24 25" />
                        </Face>
                        <Face id="27" plane="-0.593616 -0.396646 0.700208 -0.70023" album="Blasted" material="metal_bm" texgens="0.555575 -0.831467 0 237.23 -0.582205 -0.389021 -0.713933 -66.7984 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 11 10 25 26" />
                        </Face>
                        <Face id="28" plane="-0.396646 -0.593614 0.70021 -0.700226" album="Blasted" material="metal_bm" texgens="0.831466 -0.555576 0 262.201 -0.389022 -0.582204 -0.713933 -66.7984 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 12 11 26 27" />
                        </Face>
                        <Face id="29" plane="-0.139282 -0.700221 0.700208 -0.700233" album="Blasted" material="metal_bm" texgens="0.980786 -0.195089 0 287.173 -0.136604 -0.68676 -0.713933 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 13 12 27 28" />
                        </Face>
                        <Face id="30" plane="0.139281 -0.70022 0.700209 -0.700231" album="Blasted" material="metal_bm" texgens="0.980786 0.195089 0 312.145 0.136604 -0.68676 -0.713933 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 14 13 28 29" />
                        </Face>
                        <Face id="31" plane="0.396638 -0.593606 0.700221 -0.700196" album="Blasted" material="metal_bm" texgens="0.831468 0.555573 0 337.116 0.38902 -0.582206 -0.713933 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 15 14 29 30" />
                        </Face>
                        <Face id="32" plane="0.593621 -0.396638 0.700209 -0.700231" album="Blasted" material="metal_bm" texgens="0.555563 0.831474 0 362.089 0.58221 -0.389014 -0.713932 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 15 30 31" />
                        </Face>
                        <Face id="33" plane="0.700221 -0.139282 0.700208 -0.700233" album="Blasted" material="metal_bm" texgens="0.195091 0.980785 0 387.058 0.68676 -0.136605 -0.713932 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 31 16 1" />
                        </Face>
                        <Face id="34" plane="0 -0 1 0.750006" album="Blasted" material="metal_bm" texgens="0 1 0 12.4857 1 0 0 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 30 29 28 27 26 25 24 23 22 21 20 19 18 17 16" />
                        </Face>
                    </Brush>
                    <Brush id="372" owner="0" type="0" pos="-52 28 20.75" rot="1 0 0 0" scale="" transform="1 0 0 -52 0 1 0 28 0 0 1 20.75 0 0 0 1" group="-1" locked="0" nextFaceID="105" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="1.84776 0.765367 -1.25" />
                            <Vertex pos="1.84776 0.765366 1.5" />
                            <Vertex pos="2 0 -1.25" />
                            <Vertex pos="2 1.78814e-007 1.5" />
                            <Vertex pos="1.41421 1.41421 -1.25" />
                            <Vertex pos="1.41421 1.41421 1.5" />
                            <Vertex pos="0.765362 1.84776 -1.25" />
                            <Vertex pos="0.765363 1.84776 1.5" />
                            <Vertex pos="-7.62939e-006 2 -1.25" />
                            <Vertex pos="-8.06288e-006 2 1.5" />
                            <Vertex pos="-0.765377 1.84776 -1.25" />
                            <Vertex pos="-0.765375 1.84776 1.5" />
                            <Vertex pos="-1.41421 1.41422 -1.25" />
                            <Vertex pos="-1.41421 1.41422 1.5" />
                            <Vertex pos="-1.84776 0.765375 -1.25" />
                            <Vertex pos="-1.84776 0.765376 1.5" />
                            <Vertex pos="-2 4.76837e-006 -1.25" />
                            <Vertex pos="-2 5.06723e-006 1.5" />
                            <Vertex pos="-1.84776 -0.765366 -1.25" />
                            <Vertex pos="-1.84776 -0.765365 1.5" />
                            <Vertex pos="-1.41421 -1.41421 -1.25" />
                            <Vertex pos="-1.41421 -1.41421 1.5" />
                            <Vertex pos="-0.765366 -1.84776 -1.25" />
                            <Vertex pos="-0.765365 -1.84776 1.5" />
                            <Vertex pos="0 -2 -1.25" />
                            <Vertex pos="7.97368e-007 -2 1.5" />
                            <Vertex pos="0.765373 -1.84776 -1.25" />
                            <Vertex pos="0.765372 -1.84776 1.5" />
                            <Vertex pos="1.41422 -1.41421 -1.25" />
                            <Vertex pos="1.41422 -1.41421 1.5" />
                            <Vertex pos="1.84776 -0.76536 -1.25" />
                            <Vertex pos="1.84776 -0.76536 1.5" />
                        </Vertices>
                        <Face id="86" plane="0.980785 0.195089 6.76552e-008 -1.96157" album="Blasted" material="metal_bm" texgens="-0.195089 0.980786 0 12.4857 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="87" plane="0.831465 0.555576 -0 -1.96157" album="Blasted" material="metal_bm" texgens="-0.555576 0.831465 0 37.4578 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="88" plane="0.555574 0.831467 -1.92668e-007 -1.96157" album="Blasted" material="metal_bm" texgens="-0.831468 0.555573 0 62.4285 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="89" plane="0.195089 0.980786 3.07523e-008 -1.96157" album="Blasted" material="metal_bm" texgens="-0.980786 0.195089 0 87.4006 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="90" plane="-0.195089 0.980786 1.39538e-007 -1.96157" album="Blasted" material="metal_bm" texgens="-0.980786 -0.195089 0 112.372 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="91" plane="-0.555574 0.831467 0 -1.96158" album="Blasted" material="metal_bm" texgens="-0.831468 -0.555572 0 137.344 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="92" plane="-0.831466 0.555575 -1.92668e-007 -1.96157" album="Blasted" material="metal_bm" texgens="-0.555575 -0.831467 0 162.315 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="93" plane="-0.980786 0.195088 -2.12015e-008 -1.96157" album="Blasted" material="metal_bm" texgens="-0.195089 -0.980786 0 187.287 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="94" plane="-0.980786 -0.195088 7.18832e-008 -1.96157" album="Blasted" material="metal_bm" texgens="0.195089 -0.980786 0 212.258 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="95" plane="-0.831466 -0.555576 0 -1.96157" album="Blasted" material="metal_bm" texgens="0.555575 -0.831467 0 237.23 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="96" plane="-0.555576 -0.831466 2.0471e-007 -1.96157" album="Blasted" material="metal_bm" texgens="0.831466 -0.555576 0 262.201 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="97" plane="-0.195089 -0.980785 5.65666e-008 -1.96157" album="Blasted" material="metal_bm" texgens="0.980786 -0.195089 0 287.173 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="98" plane="0.195088 -0.980786 7.1883e-008 -1.96157" album="Blasted" material="metal_bm" texgens="0.980786 0.195089 0 312.145 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="99" plane="0.555574 -0.831467 0 -1.96157" album="Blasted" material="metal_bm" texgens="0.831468 0.555573 0 337.116 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="100" plane="0.831474 -0.555563 0 -1.96157" album="Blasted" material="metal_bm" texgens="0.555563 0.831474 0 362.089 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="101" plane="0.980785 -0.195091 1.26854e-008 -1.96157" album="Blasted" material="metal_bm" texgens="0.195091 0.980785 0 387.058 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 3 2 30" />
                        </Face>
                        <Face id="102" plane="-0 0 -1 -1.25" album="Blasted" material="metal_bm" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 30 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28" />
                        </Face>
                        <Face id="103" plane="0 -0 1 -1.5" album="Blasted" material="metal_bm" texgens="1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="373" owner="0" type="0" pos="-52 28 22.75" rot="1 0 0 0" scale="" transform="1 0 0 -52 0 1 0 28 0 0 1 22.75 0 0 0 1" group="-1" locked="0" nextFaceID="86" nextVertexID="18">
                        <Vertices>
                            <Vertex pos="-8.32988e-007 2.32458e-006 0.5" />
                            <Vertex pos="1.84776 0.765367 -0.5" />
                            <Vertex pos="2 -1.49012e-006 -0.5" />
                            <Vertex pos="1.41421 1.41421 -0.5" />
                            <Vertex pos="0.765363 1.84776 -0.5" />
                            <Vertex pos="-8.91321e-006 2 -0.5" />
                            <Vertex pos="-0.765374 1.84776 -0.5" />
                            <Vertex pos="-1.41421 1.41422 -0.5" />
                            <Vertex pos="-1.84776 0.765374 -0.5" />
                            <Vertex pos="-2 4.76837e-006 -0.5" />
                            <Vertex pos="-1.84776 -0.765364 -0.5" />
                            <Vertex pos="-1.41421 -1.41421 -0.5" />
                            <Vertex pos="-0.765367 -1.84776 -0.5" />
                            <Vertex pos="1.34539e-006 -2 -0.5" />
                            <Vertex pos="0.765371 -1.84776 -0.5" />
                            <Vertex pos="1.41422 -1.41421 -0.5" />
                            <Vertex pos="1.84776 -0.765358 -0.5" />
                        </Vertices>
                        <Face id="68" plane="0.445455 0.0886056 0.890909 -0.445454" album="Blasted" material="metal_bm" texgens="-0.195089 0.980786 0 12.4857 0.873791 0.173807 -0.454181 -63.1895 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="69" plane="0.377637 0.252333 0.890909 -0.445455" album="Blasted" material="metal_bm" texgens="-0.555577 0.831465 0 37.4579 0.74076 0.494968 -0.454181 -63.1894 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 1 0" />
                        </Face>
                        <Face id="70" plane="0.252332 0.377638 0.890909 -0.445455" album="Blasted" material="metal_bm" texgens="-0.831471 0.555568 0 62.429 0.494965 0.740761 -0.454184 -63.1894 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 3 0" />
                        </Face>
                        <Face id="71" plane="0.0886055 0.445455 0.890909 -0.445455" album="Blasted" material="metal_bm" texgens="-0.980785 0.195089 0 87.4006 0.173806 0.873791 -0.454181 -63.1895 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0" />
                        </Face>
                        <Face id="72" plane="-0.0886061 0.445455 0.890909 -0.445456" album="Blasted" material="metal_bm" texgens="-0.980786 -0.195089 0 112.372 -0.173807 0.873791 -0.454181 -63.1896 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 5 0" />
                        </Face>
                        <Face id="73" plane="-0.25233 0.377637 0.890909 -0.445456" album="Blasted" material="metal_bm" texgens="-0.831468 -0.555572 0 137.344 -0.494965 0.740763 -0.454181 -63.1896 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 0" />
                        </Face>
                        <Face id="74" plane="-0.377637 0.252332 0.890909 -0.445456" album="Blasted" material="metal_bm" texgens="-0.555568 -0.831471 0 162.315 -0.740761 0.494966 -0.454182 -63.1896 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 8 7 0" />
                        </Face>
                        <Face id="75" plane="-0.445455 0.0886056 0.890909 -0.445455" album="Blasted" material="metal_bm" texgens="-0.195089 -0.980785 0 187.287 -0.873791 0.173806 -0.454181 -63.1895 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 9 8 0" />
                        </Face>
                        <Face id="76" plane="-0.445455 -0.0886057 0.890909 -0.445455" album="Blasted" material="metal_bm" texgens="0.195089 -0.980786 0 212.258 -0.873791 -0.173806 -0.454181 -63.1895 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 10 9 0" />
                        </Face>
                        <Face id="77" plane="-0.377637 -0.252332 0.890909 -0.445454" album="Blasted" material="metal_bm" texgens="0.555575 -0.831466 0 237.23 -0.740761 -0.494966 -0.454182 -63.1894 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 11 10 0" />
                        </Face>
                        <Face id="78" plane="-0.252333 -0.377636 0.890909 -0.445454" album="Blasted" material="metal_bm" texgens="0.831462 -0.555582 0 262.2 -0.494968 -0.740761 -0.454179 -63.1895 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 12 11 0" />
                        </Face>
                        <Face id="79" plane="-0.0886057 -0.445454 0.890909 -0.445454" album="Blasted" material="metal_bm" texgens="0.980785 -0.195089 0 287.173 -0.173807 -0.873791 -0.454181 -63.1895 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 13 12 0" />
                        </Face>
                        <Face id="80" plane="0.0886055 -0.445454 0.890909 -0.445454" album="Blasted" material="metal_bm" texgens="0.980786 0.195088 0 312.144 0.173806 -0.873791 -0.454181 -63.1895 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 14 13 0" />
                        </Face>
                        <Face id="81" plane="0.252331 -0.377637 0.890909 -0.445454" album="Blasted" material="metal_bm" texgens="0.831467 0.555574 0 337.116 0.494965 -0.740763 -0.45418 -63.1896 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 15 14 0" />
                        </Face>
                        <Face id="82" plane="0.37764 -0.252326 0.890909 -0.445454" album="Blasted" material="metal_bm" texgens="0.555566 0.831472 0 362.089 0.740767 -0.494956 -0.454184 -63.1895 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 16 15 0" />
                        </Face>
                        <Face id="83" plane="0.445454 -0.088607 0.890909 -0.445454" album="Blasted" material="metal_bm" texgens="0.195092 0.980785 0 387.058 0.873791 -0.173808 -0.454181 -63.1895 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 16 0 2" />
                        </Face>
                        <Face id="84" plane="-0 0 -1 -0.5" album="Blasted" material="metal_bm" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 16 2 1 3 4 5 6 7 8 9 10 11 12 13 14 15" />
                        </Face>
                    </Brush>
                    <Brush id="374" owner="0" type="0" pos="-52 28 18.5" rot="1 0 0 0" scale="" transform="1 0 0 -52 0 -1 8.74228e-008 28 0 -8.74228e-008 -1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="36" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="1.84776 -0.765361 -1" />
                            <Vertex pos="2 1.19209e-007 -1" />
                            <Vertex pos="1.84776 0.765367 -1" />
                            <Vertex pos="1.41421 1.41421 -1" />
                            <Vertex pos="0.765362 1.84776 -1" />
                            <Vertex pos="-6.89454e-006 2 -1" />
                            <Vertex pos="-0.765376 1.84776 -1" />
                            <Vertex pos="-1.41421 1.41422 -1" />
                            <Vertex pos="-1.84776 0.765374 -1" />
                            <Vertex pos="-2 4.88758e-006 -1" />
                            <Vertex pos="-1.84776 -0.765363 -1" />
                            <Vertex pos="-1.41421 -1.41421 -1" />
                            <Vertex pos="-0.765366 -1.84776 -1" />
                            <Vertex pos="1.34345e-006 -2 -1" />
                            <Vertex pos="0.765371 -1.84776 -1" />
                            <Vertex pos="1.41422 -1.41421 -1" />
                            <Vertex pos="1.75001 5.9606e-008 -0.750006" />
                            <Vertex pos="1.6168 0.669698 -0.750006" />
                            <Vertex pos="1.23744 1.23744 -0.750007" />
                            <Vertex pos="0.669694 1.6168 -0.750007" />
                            <Vertex pos="-6.17804e-006 1.75001 -0.750007" />
                            <Vertex pos="-0.669706 1.6168 -0.750007" />
                            <Vertex pos="-1.23744 1.23745 -0.750007" />
                            <Vertex pos="-1.6168 0.669705 -0.750006" />
                            <Vertex pos="-1.75001 4.23194e-006 -0.750006" />
                            <Vertex pos="-1.6168 -0.669695 -0.750006" />
                            <Vertex pos="-1.23744 -1.23744 -0.750006" />
                            <Vertex pos="-0.669697 -1.6168 -0.750006" />
                            <Vertex pos="1.03023e-006 -1.75001 -0.750006" />
                            <Vertex pos="0.669702 -1.61679 -0.750006" />
                            <Vertex pos="1.23745 -1.23744 -0.750006" />
                            <Vertex pos="1.6168 -0.669693 -0.750006" />
                        </Vertices>
                        <Face id="17" plane="-0 0 -1 -1" album="Blasted" material="metal_bm" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15" />
                        </Face>
                        <Face id="18" plane="0.70022 0.139281 0.700209 -0.700231" album="Blasted" material="metal_bm" texgens="-0.195089 0.980785 0 12.4857 0.68676 0.136604 -0.713933 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 16 17 2" />
                        </Face>
                        <Face id="19" plane="0.593615 0.396647 0.700209 -0.700229" album="Blasted" material="metal_bm" texgens="-0.555576 0.831466 0 37.4578 0.582204 0.389023 -0.713933 -66.7984 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 17 18" />
                        </Face>
                        <Face id="20" plane="0.396644 0.593614 0.700211 -0.700222" album="Blasted" material="metal_bm" texgens="-0.831467 0.555574 0 62.4285 0.38902 0.582205 -0.713933 -66.7984 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 3 18 19" />
                        </Face>
                        <Face id="21" plane="0.139281 0.70022 0.700209 -0.700229" album="Blasted" material="metal_bm" texgens="-0.980786 0.195089 0 87.4006 0.136604 0.68676 -0.713933 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 19 20" />
                        </Face>
                        <Face id="22" plane="-0.139281 0.700219 0.70021 -0.700228" album="Blasted" material="metal_bm" texgens="-0.980785 -0.195089 0 112.372 -0.136604 0.68676 -0.713933 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 5 20 21" />
                        </Face>
                        <Face id="23" plane="-0.396643 0.593614 0.700212 -0.700226" album="Blasted" material="metal_bm" texgens="-0.831468 -0.555573 0 137.344 -0.38902 0.582206 -0.713932 -66.7986 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 21 22" />
                        </Face>
                        <Face id="24" plane="-0.593614 0.396645 0.700211 -0.700226" album="Blasted" material="metal_bm" texgens="-0.555575 -0.831467 0 162.315 -0.582205 0.389022 -0.713932 -66.7986 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 8 7 22 23" />
                        </Face>
                        <Face id="25" plane="-0.700221 0.139281 0.700208 -0.700234" album="Blasted" material="metal_bm" texgens="-0.195089 -0.980785 0 187.287 -0.68676 0.136604 -0.713932 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 9 8 23 24" />
                        </Face>
                        <Face id="26" plane="-0.70022 -0.139281 0.700209 -0.700231" album="Blasted" material="metal_bm" texgens="0.195089 -0.980786 0 212.258 -0.68676 -0.136604 -0.713933 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 10 9 24 25" />
                        </Face>
                        <Face id="27" plane="-0.593616 -0.396646 0.700208 -0.70023" album="Blasted" material="metal_bm" texgens="0.555575 -0.831467 0 237.23 -0.582205 -0.389021 -0.713933 -66.7984 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 11 10 25 26" />
                        </Face>
                        <Face id="28" plane="-0.396646 -0.593614 0.70021 -0.700226" album="Blasted" material="metal_bm" texgens="0.831466 -0.555576 0 262.201 -0.389022 -0.582204 -0.713933 -66.7984 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 12 11 26 27" />
                        </Face>
                        <Face id="29" plane="-0.139282 -0.700221 0.700208 -0.700233" album="Blasted" material="metal_bm" texgens="0.980786 -0.195089 0 287.173 -0.136604 -0.68676 -0.713933 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 13 12 27 28" />
                        </Face>
                        <Face id="30" plane="0.139281 -0.70022 0.700209 -0.700231" album="Blasted" material="metal_bm" texgens="0.980786 0.195089 0 312.145 0.136604 -0.68676 -0.713933 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 14 13 28 29" />
                        </Face>
                        <Face id="31" plane="0.396638 -0.593606 0.700221 -0.700196" album="Blasted" material="metal_bm" texgens="0.831468 0.555573 0 337.116 0.38902 -0.582206 -0.713933 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 15 14 29 30" />
                        </Face>
                        <Face id="32" plane="0.593621 -0.396638 0.700209 -0.700231" album="Blasted" material="metal_bm" texgens="0.555563 0.831474 0 362.089 0.58221 -0.389014 -0.713932 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 15 30 31" />
                        </Face>
                        <Face id="33" plane="0.700221 -0.139282 0.700208 -0.700233" album="Blasted" material="metal_bm" texgens="0.195091 0.980785 0 387.058 0.68676 -0.136605 -0.713932 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 31 16 1" />
                        </Face>
                        <Face id="34" plane="0 -0 1 0.750006" album="Blasted" material="metal_bm" texgens="0 1 0 12.4857 1 0 0 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 30 29 28 27 26 25 24 23 22 21 20 19 18 17 16" />
                        </Face>
                    </Brush>
                    <Brush id="375" owner="0" type="0" pos="-10 28 21.75" rot="1 0 0 0" scale="" transform="1 0 0 -10 0 1 0 28 0 0 1 21.75 0 0 0 1" group="-1" locked="0" nextFaceID="105" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="1.84776 0.765367 -1.25" />
                            <Vertex pos="1.84776 0.765366 1.5" />
                            <Vertex pos="2 0 -1.25" />
                            <Vertex pos="2 1.78814e-007 1.5" />
                            <Vertex pos="1.41421 1.41421 -1.25" />
                            <Vertex pos="1.41421 1.41421 1.5" />
                            <Vertex pos="0.765362 1.84776 -1.25" />
                            <Vertex pos="0.765363 1.84776 1.5" />
                            <Vertex pos="-7.62939e-006 2 -1.25" />
                            <Vertex pos="-8.06288e-006 2 1.5" />
                            <Vertex pos="-0.765377 1.84776 -1.25" />
                            <Vertex pos="-0.765375 1.84776 1.5" />
                            <Vertex pos="-1.41421 1.41422 -1.25" />
                            <Vertex pos="-1.41421 1.41422 1.5" />
                            <Vertex pos="-1.84776 0.765375 -1.25" />
                            <Vertex pos="-1.84776 0.765376 1.5" />
                            <Vertex pos="-2 4.76837e-006 -1.25" />
                            <Vertex pos="-2 5.06723e-006 1.5" />
                            <Vertex pos="-1.84776 -0.765366 -1.25" />
                            <Vertex pos="-1.84776 -0.765365 1.5" />
                            <Vertex pos="-1.41421 -1.41421 -1.25" />
                            <Vertex pos="-1.41421 -1.41421 1.5" />
                            <Vertex pos="-0.765366 -1.84776 -1.25" />
                            <Vertex pos="-0.765365 -1.84776 1.5" />
                            <Vertex pos="0 -2 -1.25" />
                            <Vertex pos="7.97368e-007 -2 1.5" />
                            <Vertex pos="0.765373 -1.84776 -1.25" />
                            <Vertex pos="0.765372 -1.84776 1.5" />
                            <Vertex pos="1.41422 -1.41421 -1.25" />
                            <Vertex pos="1.41422 -1.41421 1.5" />
                            <Vertex pos="1.84776 -0.76536 -1.25" />
                            <Vertex pos="1.84776 -0.76536 1.5" />
                        </Vertices>
                        <Face id="86" plane="0.980785 0.195089 6.76552e-008 -1.96157" album="Blasted" material="metal_bm" texgens="-0.195089 0.980786 0 12.4857 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="87" plane="0.831465 0.555576 -0 -1.96157" album="Blasted" material="metal_bm" texgens="-0.555576 0.831465 0 37.4578 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="88" plane="0.555574 0.831467 -1.92668e-007 -1.96157" album="Blasted" material="metal_bm" texgens="-0.831468 0.555573 0 62.4285 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="89" plane="0.195089 0.980786 3.07523e-008 -1.96157" album="Blasted" material="metal_bm" texgens="-0.980786 0.195089 0 87.4006 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="90" plane="-0.195089 0.980786 1.39538e-007 -1.96157" album="Blasted" material="metal_bm" texgens="-0.980786 -0.195089 0 112.372 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="91" plane="-0.555574 0.831467 0 -1.96158" album="Blasted" material="metal_bm" texgens="-0.831468 -0.555572 0 137.344 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="92" plane="-0.831466 0.555575 -1.92668e-007 -1.96157" album="Blasted" material="metal_bm" texgens="-0.555575 -0.831467 0 162.315 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="93" plane="-0.980786 0.195088 -2.12015e-008 -1.96157" album="Blasted" material="metal_bm" texgens="-0.195089 -0.980786 0 187.287 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="94" plane="-0.980786 -0.195088 7.18832e-008 -1.96157" album="Blasted" material="metal_bm" texgens="0.195089 -0.980786 0 212.258 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="95" plane="-0.831466 -0.555576 0 -1.96157" album="Blasted" material="metal_bm" texgens="0.555575 -0.831467 0 237.23 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="96" plane="-0.555576 -0.831466 2.0471e-007 -1.96157" album="Blasted" material="metal_bm" texgens="0.831466 -0.555576 0 262.201 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="97" plane="-0.195089 -0.980785 5.65666e-008 -1.96157" album="Blasted" material="metal_bm" texgens="0.980786 -0.195089 0 287.173 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="98" plane="0.195088 -0.980786 7.1883e-008 -1.96157" album="Blasted" material="metal_bm" texgens="0.980786 0.195089 0 312.145 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="99" plane="0.555574 -0.831467 0 -1.96157" album="Blasted" material="metal_bm" texgens="0.831468 0.555573 0 337.116 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="100" plane="0.831474 -0.555563 0 -1.96157" album="Blasted" material="metal_bm" texgens="0.555563 0.831474 0 362.089 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="101" plane="0.980785 -0.195091 1.26854e-008 -1.96157" album="Blasted" material="metal_bm" texgens="0.195091 0.980785 0 387.058 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 3 2 30" />
                        </Face>
                        <Face id="102" plane="-0 0 -1 -1.25" album="Blasted" material="metal_bm" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 30 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28" />
                        </Face>
                        <Face id="103" plane="0 -0 1 -1.5" album="Blasted" material="metal_bm" texgens="1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="376" owner="0" type="0" pos="-10 28 23.75" rot="1 0 0 0" scale="" transform="1 0 0 -10 0 1 0 28 0 0 1 23.75 0 0 0 1" group="-1" locked="0" nextFaceID="86" nextVertexID="18">
                        <Vertices>
                            <Vertex pos="-8.32988e-007 2.32458e-006 0.5" />
                            <Vertex pos="1.84776 0.765367 -0.5" />
                            <Vertex pos="2 -1.49012e-006 -0.5" />
                            <Vertex pos="1.41421 1.41421 -0.5" />
                            <Vertex pos="0.765363 1.84776 -0.5" />
                            <Vertex pos="-8.91321e-006 2 -0.5" />
                            <Vertex pos="-0.765374 1.84776 -0.5" />
                            <Vertex pos="-1.41421 1.41422 -0.5" />
                            <Vertex pos="-1.84776 0.765374 -0.5" />
                            <Vertex pos="-2 4.76837e-006 -0.5" />
                            <Vertex pos="-1.84776 -0.765364 -0.5" />
                            <Vertex pos="-1.41421 -1.41421 -0.5" />
                            <Vertex pos="-0.765367 -1.84776 -0.5" />
                            <Vertex pos="1.34539e-006 -2 -0.5" />
                            <Vertex pos="0.765371 -1.84776 -0.5" />
                            <Vertex pos="1.41422 -1.41421 -0.5" />
                            <Vertex pos="1.84776 -0.765358 -0.5" />
                        </Vertices>
                        <Face id="68" plane="0.445455 0.0886056 0.890909 -0.445454" album="Blasted" material="metal_bm" texgens="-0.195089 0.980786 0 12.4857 0.873791 0.173807 -0.454181 -63.1895 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="69" plane="0.377637 0.252333 0.890909 -0.445455" album="Blasted" material="metal_bm" texgens="-0.555577 0.831465 0 37.4579 0.74076 0.494968 -0.454181 -63.1894 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 1 0" />
                        </Face>
                        <Face id="70" plane="0.252332 0.377638 0.890909 -0.445455" album="Blasted" material="metal_bm" texgens="-0.831471 0.555568 0 62.429 0.494965 0.740761 -0.454184 -63.1894 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 3 0" />
                        </Face>
                        <Face id="71" plane="0.0886055 0.445455 0.890909 -0.445455" album="Blasted" material="metal_bm" texgens="-0.980785 0.195089 0 87.4006 0.173806 0.873791 -0.454181 -63.1895 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0" />
                        </Face>
                        <Face id="72" plane="-0.0886061 0.445455 0.890909 -0.445456" album="Blasted" material="metal_bm" texgens="-0.980786 -0.195089 0 112.372 -0.173807 0.873791 -0.454181 -63.1896 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 5 0" />
                        </Face>
                        <Face id="73" plane="-0.25233 0.377637 0.890909 -0.445456" album="Blasted" material="metal_bm" texgens="-0.831468 -0.555572 0 137.344 -0.494965 0.740763 -0.454181 -63.1896 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 0" />
                        </Face>
                        <Face id="74" plane="-0.377637 0.252332 0.890909 -0.445456" album="Blasted" material="metal_bm" texgens="-0.555568 -0.831471 0 162.315 -0.740761 0.494966 -0.454182 -63.1896 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 8 7 0" />
                        </Face>
                        <Face id="75" plane="-0.445455 0.0886056 0.890909 -0.445455" album="Blasted" material="metal_bm" texgens="-0.195089 -0.980785 0 187.287 -0.873791 0.173806 -0.454181 -63.1895 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 9 8 0" />
                        </Face>
                        <Face id="76" plane="-0.445455 -0.0886057 0.890909 -0.445455" album="Blasted" material="metal_bm" texgens="0.195089 -0.980786 0 212.258 -0.873791 -0.173806 -0.454181 -63.1895 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 10 9 0" />
                        </Face>
                        <Face id="77" plane="-0.377637 -0.252332 0.890909 -0.445454" album="Blasted" material="metal_bm" texgens="0.555575 -0.831466 0 237.23 -0.740761 -0.494966 -0.454182 -63.1894 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 11 10 0" />
                        </Face>
                        <Face id="78" plane="-0.252333 -0.377636 0.890909 -0.445454" album="Blasted" material="metal_bm" texgens="0.831462 -0.555582 0 262.2 -0.494968 -0.740761 -0.454179 -63.1895 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 12 11 0" />
                        </Face>
                        <Face id="79" plane="-0.0886057 -0.445454 0.890909 -0.445454" album="Blasted" material="metal_bm" texgens="0.980785 -0.195089 0 287.173 -0.173807 -0.873791 -0.454181 -63.1895 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 13 12 0" />
                        </Face>
                        <Face id="80" plane="0.0886055 -0.445454 0.890909 -0.445454" album="Blasted" material="metal_bm" texgens="0.980786 0.195088 0 312.144 0.173806 -0.873791 -0.454181 -63.1895 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 14 13 0" />
                        </Face>
                        <Face id="81" plane="0.252331 -0.377637 0.890909 -0.445454" album="Blasted" material="metal_bm" texgens="0.831467 0.555574 0 337.116 0.494965 -0.740763 -0.45418 -63.1896 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 15 14 0" />
                        </Face>
                        <Face id="82" plane="0.37764 -0.252326 0.890909 -0.445454" album="Blasted" material="metal_bm" texgens="0.555566 0.831472 0 362.089 0.740767 -0.494956 -0.454184 -63.1895 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 16 15 0" />
                        </Face>
                        <Face id="83" plane="0.445454 -0.088607 0.890909 -0.445454" album="Blasted" material="metal_bm" texgens="0.195092 0.980785 0 387.058 0.873791 -0.173808 -0.454181 -63.1895 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 16 0 2" />
                        </Face>
                        <Face id="84" plane="-0 0 -1 -0.5" album="Blasted" material="metal_bm" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 16 2 1 3 4 5 6 7 8 9 10 11 12 13 14 15" />
                        </Face>
                    </Brush>
                    <Brush id="377" owner="0" type="0" pos="-10 28 19.5" rot="1 0 0 0" scale="" transform="1 0 0 -10 0 -1 8.74228e-008 28 0 -8.74228e-008 -1 19.5 0 0 0 1" group="-1" locked="0" nextFaceID="36" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="1.84776 -0.765361 -1" />
                            <Vertex pos="2 1.19209e-007 -1" />
                            <Vertex pos="1.84776 0.765367 -1" />
                            <Vertex pos="1.41421 1.41421 -1" />
                            <Vertex pos="0.765362 1.84776 -1" />
                            <Vertex pos="-6.89454e-006 2 -1" />
                            <Vertex pos="-0.765376 1.84776 -1" />
                            <Vertex pos="-1.41421 1.41422 -1" />
                            <Vertex pos="-1.84776 0.765374 -1" />
                            <Vertex pos="-2 4.88758e-006 -1" />
                            <Vertex pos="-1.84776 -0.765363 -1" />
                            <Vertex pos="-1.41421 -1.41421 -1" />
                            <Vertex pos="-0.765366 -1.84776 -1" />
                            <Vertex pos="1.34345e-006 -2 -1" />
                            <Vertex pos="0.765371 -1.84776 -1" />
                            <Vertex pos="1.41422 -1.41421 -1" />
                            <Vertex pos="1.75001 5.9606e-008 -0.750006" />
                            <Vertex pos="1.6168 0.669698 -0.750006" />
                            <Vertex pos="1.23744 1.23744 -0.750007" />
                            <Vertex pos="0.669694 1.6168 -0.750007" />
                            <Vertex pos="-6.17804e-006 1.75001 -0.750007" />
                            <Vertex pos="-0.669706 1.6168 -0.750007" />
                            <Vertex pos="-1.23744 1.23745 -0.750007" />
                            <Vertex pos="-1.6168 0.669705 -0.750006" />
                            <Vertex pos="-1.75001 4.23194e-006 -0.750006" />
                            <Vertex pos="-1.6168 -0.669695 -0.750006" />
                            <Vertex pos="-1.23744 -1.23744 -0.750006" />
                            <Vertex pos="-0.669697 -1.6168 -0.750006" />
                            <Vertex pos="1.03023e-006 -1.75001 -0.750006" />
                            <Vertex pos="0.669702 -1.61679 -0.750006" />
                            <Vertex pos="1.23745 -1.23744 -0.750006" />
                            <Vertex pos="1.6168 -0.669693 -0.750006" />
                        </Vertices>
                        <Face id="17" plane="-0 0 -1 -1" album="Blasted" material="metal_bm" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15" />
                        </Face>
                        <Face id="18" plane="0.70022 0.139281 0.700209 -0.700231" album="Blasted" material="metal_bm" texgens="-0.195089 0.980785 0 12.4857 0.68676 0.136604 -0.713933 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 16 17 2" />
                        </Face>
                        <Face id="19" plane="0.593615 0.396647 0.700209 -0.700229" album="Blasted" material="metal_bm" texgens="-0.555576 0.831466 0 37.4578 0.582204 0.389023 -0.713933 -66.7984 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 17 18" />
                        </Face>
                        <Face id="20" plane="0.396644 0.593614 0.700211 -0.700222" album="Blasted" material="metal_bm" texgens="-0.831467 0.555574 0 62.4285 0.38902 0.582205 -0.713933 -66.7984 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 3 18 19" />
                        </Face>
                        <Face id="21" plane="0.139281 0.70022 0.700209 -0.700229" album="Blasted" material="metal_bm" texgens="-0.980786 0.195089 0 87.4006 0.136604 0.68676 -0.713933 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 19 20" />
                        </Face>
                        <Face id="22" plane="-0.139281 0.700219 0.70021 -0.700228" album="Blasted" material="metal_bm" texgens="-0.980785 -0.195089 0 112.372 -0.136604 0.68676 -0.713933 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 5 20 21" />
                        </Face>
                        <Face id="23" plane="-0.396643 0.593614 0.700212 -0.700226" album="Blasted" material="metal_bm" texgens="-0.831468 -0.555573 0 137.344 -0.38902 0.582206 -0.713932 -66.7986 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 21 22" />
                        </Face>
                        <Face id="24" plane="-0.593614 0.396645 0.700211 -0.700226" album="Blasted" material="metal_bm" texgens="-0.555575 -0.831467 0 162.315 -0.582205 0.389022 -0.713932 -66.7986 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 8 7 22 23" />
                        </Face>
                        <Face id="25" plane="-0.700221 0.139281 0.700208 -0.700234" album="Blasted" material="metal_bm" texgens="-0.195089 -0.980785 0 187.287 -0.68676 0.136604 -0.713932 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 9 8 23 24" />
                        </Face>
                        <Face id="26" plane="-0.70022 -0.139281 0.700209 -0.700231" album="Blasted" material="metal_bm" texgens="0.195089 -0.980786 0 212.258 -0.68676 -0.136604 -0.713933 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 10 9 24 25" />
                        </Face>
                        <Face id="27" plane="-0.593616 -0.396646 0.700208 -0.70023" album="Blasted" material="metal_bm" texgens="0.555575 -0.831467 0 237.23 -0.582205 -0.389021 -0.713933 -66.7984 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 11 10 25 26" />
                        </Face>
                        <Face id="28" plane="-0.396646 -0.593614 0.70021 -0.700226" album="Blasted" material="metal_bm" texgens="0.831466 -0.555576 0 262.201 -0.389022 -0.582204 -0.713933 -66.7984 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 12 11 26 27" />
                        </Face>
                        <Face id="29" plane="-0.139282 -0.700221 0.700208 -0.700233" album="Blasted" material="metal_bm" texgens="0.980786 -0.195089 0 287.173 -0.136604 -0.68676 -0.713933 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 13 12 27 28" />
                        </Face>
                        <Face id="30" plane="0.139281 -0.70022 0.700209 -0.700231" album="Blasted" material="metal_bm" texgens="0.980786 0.195089 0 312.145 0.136604 -0.68676 -0.713933 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 14 13 28 29" />
                        </Face>
                        <Face id="31" plane="0.396638 -0.593606 0.700221 -0.700196" album="Blasted" material="metal_bm" texgens="0.831468 0.555573 0 337.116 0.38902 -0.582206 -0.713933 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 15 14 29 30" />
                        </Face>
                        <Face id="32" plane="0.593621 -0.396638 0.700209 -0.700231" album="Blasted" material="metal_bm" texgens="0.555563 0.831474 0 362.089 0.58221 -0.389014 -0.713932 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 15 30 31" />
                        </Face>
                        <Face id="33" plane="0.700221 -0.139282 0.700208 -0.700233" album="Blasted" material="metal_bm" texgens="0.195091 0.980785 0 387.058 0.68676 -0.136605 -0.713932 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 31 16 1" />
                        </Face>
                        <Face id="34" plane="0 -0 1 0.750006" album="Blasted" material="metal_bm" texgens="0 1 0 12.4857 1 0 0 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 30 29 28 27 26 25 24 23 22 21 20 19 18 17 16" />
                        </Face>
                    </Brush>
                    <Brush id="378" owner="0" type="0" pos="-10 41 22.25" rot="1 0 0 0" scale="" transform="1 0 0 -10 0 1 0 41 0 0 1 22.25 0 0 0 1" group="-1" locked="0" nextFaceID="105" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="1.84776 0.765367 -1.25" />
                            <Vertex pos="1.84776 0.765366 1.5" />
                            <Vertex pos="2 0 -1.25" />
                            <Vertex pos="2 1.78814e-007 1.5" />
                            <Vertex pos="1.41421 1.41421 -1.25" />
                            <Vertex pos="1.41421 1.41421 1.5" />
                            <Vertex pos="0.765362 1.84776 -1.25" />
                            <Vertex pos="0.765363 1.84776 1.5" />
                            <Vertex pos="-7.62939e-006 2 -1.25" />
                            <Vertex pos="-8.06288e-006 2 1.5" />
                            <Vertex pos="-0.765377 1.84776 -1.25" />
                            <Vertex pos="-0.765375 1.84776 1.5" />
                            <Vertex pos="-1.41421 1.41422 -1.25" />
                            <Vertex pos="-1.41421 1.41422 1.5" />
                            <Vertex pos="-1.84776 0.765375 -1.25" />
                            <Vertex pos="-1.84776 0.765376 1.5" />
                            <Vertex pos="-2 4.76837e-006 -1.25" />
                            <Vertex pos="-2 5.06723e-006 1.5" />
                            <Vertex pos="-1.84776 -0.765366 -1.25" />
                            <Vertex pos="-1.84776 -0.765365 1.5" />
                            <Vertex pos="-1.41421 -1.41421 -1.25" />
                            <Vertex pos="-1.41421 -1.41421 1.5" />
                            <Vertex pos="-0.765366 -1.84776 -1.25" />
                            <Vertex pos="-0.765365 -1.84776 1.5" />
                            <Vertex pos="0 -2 -1.25" />
                            <Vertex pos="7.97368e-007 -2 1.5" />
                            <Vertex pos="0.765373 -1.84776 -1.25" />
                            <Vertex pos="0.765372 -1.84776 1.5" />
                            <Vertex pos="1.41422 -1.41421 -1.25" />
                            <Vertex pos="1.41422 -1.41421 1.5" />
                            <Vertex pos="1.84776 -0.76536 -1.25" />
                            <Vertex pos="1.84776 -0.76536 1.5" />
                        </Vertices>
                        <Face id="86" plane="0.980785 0.195089 6.76552e-008 -1.96157" album="Blasted" material="metal_bm" texgens="-0.195089 0.980786 0 12.4857 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="87" plane="0.831465 0.555576 -0 -1.96157" album="Blasted" material="metal_bm" texgens="-0.555576 0.831465 0 37.4578 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="88" plane="0.555574 0.831467 -1.92668e-007 -1.96157" album="Blasted" material="metal_bm" texgens="-0.831468 0.555573 0 62.4285 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="89" plane="0.195089 0.980786 3.07523e-008 -1.96157" album="Blasted" material="metal_bm" texgens="-0.980786 0.195089 0 87.4006 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="90" plane="-0.195089 0.980786 1.39538e-007 -1.96157" album="Blasted" material="metal_bm" texgens="-0.980786 -0.195089 0 112.372 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="91" plane="-0.555574 0.831467 0 -1.96158" album="Blasted" material="metal_bm" texgens="-0.831468 -0.555572 0 137.344 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="92" plane="-0.831466 0.555575 -1.92668e-007 -1.96157" album="Blasted" material="metal_bm" texgens="-0.555575 -0.831467 0 162.315 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="93" plane="-0.980786 0.195088 -2.12015e-008 -1.96157" album="Blasted" material="metal_bm" texgens="-0.195089 -0.980786 0 187.287 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="94" plane="-0.980786 -0.195088 7.18832e-008 -1.96157" album="Blasted" material="metal_bm" texgens="0.195089 -0.980786 0 212.258 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="95" plane="-0.831466 -0.555576 0 -1.96157" album="Blasted" material="metal_bm" texgens="0.555575 -0.831467 0 237.23 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="96" plane="-0.555576 -0.831466 2.0471e-007 -1.96157" album="Blasted" material="metal_bm" texgens="0.831466 -0.555576 0 262.201 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="97" plane="-0.195089 -0.980785 5.65666e-008 -1.96157" album="Blasted" material="metal_bm" texgens="0.980786 -0.195089 0 287.173 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="98" plane="0.195088 -0.980786 7.1883e-008 -1.96157" album="Blasted" material="metal_bm" texgens="0.980786 0.195089 0 312.145 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="99" plane="0.555574 -0.831467 0 -1.96157" album="Blasted" material="metal_bm" texgens="0.831468 0.555573 0 337.116 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="100" plane="0.831474 -0.555563 0 -1.96157" album="Blasted" material="metal_bm" texgens="0.555563 0.831474 0 362.089 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="101" plane="0.980785 -0.195091 1.26854e-008 -1.96157" album="Blasted" material="metal_bm" texgens="0.195091 0.980785 0 387.058 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 3 2 30" />
                        </Face>
                        <Face id="102" plane="-0 0 -1 -1.25" album="Blasted" material="metal_bm" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 30 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28" />
                        </Face>
                        <Face id="103" plane="0 -0 1 -1.5" album="Blasted" material="metal_bm" texgens="1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="379" owner="0" type="0" pos="-10 41 24.25" rot="1 0 0 0" scale="" transform="1 0 0 -10 0 1 0 41 0 0 1 24.25 0 0 0 1" group="-1" locked="0" nextFaceID="86" nextVertexID="18">
                        <Vertices>
                            <Vertex pos="-8.32988e-007 2.32458e-006 0.5" />
                            <Vertex pos="1.84776 0.765367 -0.5" />
                            <Vertex pos="2 -1.49012e-006 -0.5" />
                            <Vertex pos="1.41421 1.41421 -0.5" />
                            <Vertex pos="0.765363 1.84776 -0.5" />
                            <Vertex pos="-8.91321e-006 2 -0.5" />
                            <Vertex pos="-0.765374 1.84776 -0.5" />
                            <Vertex pos="-1.41421 1.41422 -0.5" />
                            <Vertex pos="-1.84776 0.765374 -0.5" />
                            <Vertex pos="-2 4.76837e-006 -0.5" />
                            <Vertex pos="-1.84776 -0.765364 -0.5" />
                            <Vertex pos="-1.41421 -1.41421 -0.5" />
                            <Vertex pos="-0.765367 -1.84776 -0.5" />
                            <Vertex pos="1.34539e-006 -2 -0.5" />
                            <Vertex pos="0.765371 -1.84776 -0.5" />
                            <Vertex pos="1.41422 -1.41421 -0.5" />
                            <Vertex pos="1.84776 -0.765358 -0.5" />
                        </Vertices>
                        <Face id="68" plane="0.445455 0.0886056 0.890909 -0.445454" album="Blasted" material="metal_bm" texgens="-0.195089 0.980786 0 12.4857 0.873791 0.173807 -0.454181 -63.1895 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="69" plane="0.377637 0.252333 0.890909 -0.445455" album="Blasted" material="metal_bm" texgens="-0.555577 0.831465 0 37.4579 0.74076 0.494968 -0.454181 -63.1894 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 1 0" />
                        </Face>
                        <Face id="70" plane="0.252332 0.377638 0.890909 -0.445455" album="Blasted" material="metal_bm" texgens="-0.831471 0.555568 0 62.429 0.494965 0.740761 -0.454184 -63.1894 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 3 0" />
                        </Face>
                        <Face id="71" plane="0.0886055 0.445455 0.890909 -0.445455" album="Blasted" material="metal_bm" texgens="-0.980785 0.195089 0 87.4006 0.173806 0.873791 -0.454181 -63.1895 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0" />
                        </Face>
                        <Face id="72" plane="-0.0886061 0.445455 0.890909 -0.445456" album="Blasted" material="metal_bm" texgens="-0.980786 -0.195089 0 112.372 -0.173807 0.873791 -0.454181 -63.1896 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 5 0" />
                        </Face>
                        <Face id="73" plane="-0.25233 0.377637 0.890909 -0.445456" album="Blasted" material="metal_bm" texgens="-0.831468 -0.555572 0 137.344 -0.494965 0.740763 -0.454181 -63.1896 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 0" />
                        </Face>
                        <Face id="74" plane="-0.377637 0.252332 0.890909 -0.445456" album="Blasted" material="metal_bm" texgens="-0.555568 -0.831471 0 162.315 -0.740761 0.494966 -0.454182 -63.1896 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 8 7 0" />
                        </Face>
                        <Face id="75" plane="-0.445455 0.0886056 0.890909 -0.445455" album="Blasted" material="metal_bm" texgens="-0.195089 -0.980785 0 187.287 -0.873791 0.173806 -0.454181 -63.1895 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 9 8 0" />
                        </Face>
                        <Face id="76" plane="-0.445455 -0.0886057 0.890909 -0.445455" album="Blasted" material="metal_bm" texgens="0.195089 -0.980786 0 212.258 -0.873791 -0.173806 -0.454181 -63.1895 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 10 9 0" />
                        </Face>
                        <Face id="77" plane="-0.377637 -0.252332 0.890909 -0.445454" album="Blasted" material="metal_bm" texgens="0.555575 -0.831466 0 237.23 -0.740761 -0.494966 -0.454182 -63.1894 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 11 10 0" />
                        </Face>
                        <Face id="78" plane="-0.252333 -0.377636 0.890909 -0.445454" album="Blasted" material="metal_bm" texgens="0.831462 -0.555582 0 262.2 -0.494968 -0.740761 -0.454179 -63.1895 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 12 11 0" />
                        </Face>
                        <Face id="79" plane="-0.0886057 -0.445454 0.890909 -0.445454" album="Blasted" material="metal_bm" texgens="0.980785 -0.195089 0 287.173 -0.173807 -0.873791 -0.454181 -63.1895 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 13 12 0" />
                        </Face>
                        <Face id="80" plane="0.0886055 -0.445454 0.890909 -0.445454" album="Blasted" material="metal_bm" texgens="0.980786 0.195088 0 312.144 0.173806 -0.873791 -0.454181 -63.1895 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 14 13 0" />
                        </Face>
                        <Face id="81" plane="0.252331 -0.377637 0.890909 -0.445454" album="Blasted" material="metal_bm" texgens="0.831467 0.555574 0 337.116 0.494965 -0.740763 -0.45418 -63.1896 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 15 14 0" />
                        </Face>
                        <Face id="82" plane="0.37764 -0.252326 0.890909 -0.445454" album="Blasted" material="metal_bm" texgens="0.555566 0.831472 0 362.089 0.740767 -0.494956 -0.454184 -63.1895 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 16 15 0" />
                        </Face>
                        <Face id="83" plane="0.445454 -0.088607 0.890909 -0.445454" album="Blasted" material="metal_bm" texgens="0.195092 0.980785 0 387.058 0.873791 -0.173808 -0.454181 -63.1895 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 16 0 2" />
                        </Face>
                        <Face id="84" plane="-0 0 -1 -0.5" album="Blasted" material="metal_bm" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 16 2 1 3 4 5 6 7 8 9 10 11 12 13 14 15" />
                        </Face>
                    </Brush>
                    <Brush id="380" owner="0" type="0" pos="-10 41 20" rot="1 0 0 0" scale="" transform="1 0 0 -10 0 -1 8.74228e-008 41 0 -8.74228e-008 -1 20 0 0 0 1" group="-1" locked="0" nextFaceID="36" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="1.84776 -0.765361 -1" />
                            <Vertex pos="2 1.19209e-007 -1" />
                            <Vertex pos="1.84776 0.765367 -1" />
                            <Vertex pos="1.41421 1.41421 -1" />
                            <Vertex pos="0.765362 1.84776 -1" />
                            <Vertex pos="-6.89454e-006 2 -1" />
                            <Vertex pos="-0.765376 1.84776 -1" />
                            <Vertex pos="-1.41421 1.41422 -1" />
                            <Vertex pos="-1.84776 0.765374 -1" />
                            <Vertex pos="-2 4.88758e-006 -1" />
                            <Vertex pos="-1.84776 -0.765363 -1" />
                            <Vertex pos="-1.41421 -1.41421 -1" />
                            <Vertex pos="-0.765366 -1.84776 -1" />
                            <Vertex pos="1.34345e-006 -2 -1" />
                            <Vertex pos="0.765371 -1.84776 -1" />
                            <Vertex pos="1.41422 -1.41421 -1" />
                            <Vertex pos="1.75001 5.9606e-008 -0.750006" />
                            <Vertex pos="1.6168 0.669698 -0.750006" />
                            <Vertex pos="1.23744 1.23744 -0.750007" />
                            <Vertex pos="0.669694 1.6168 -0.750007" />
                            <Vertex pos="-6.17804e-006 1.75001 -0.750007" />
                            <Vertex pos="-0.669706 1.6168 -0.750007" />
                            <Vertex pos="-1.23744 1.23745 -0.750007" />
                            <Vertex pos="-1.6168 0.669705 -0.750006" />
                            <Vertex pos="-1.75001 4.23194e-006 -0.750006" />
                            <Vertex pos="-1.6168 -0.669695 -0.750006" />
                            <Vertex pos="-1.23744 -1.23744 -0.750006" />
                            <Vertex pos="-0.669697 -1.6168 -0.750006" />
                            <Vertex pos="1.03023e-006 -1.75001 -0.750006" />
                            <Vertex pos="0.669702 -1.61679 -0.750006" />
                            <Vertex pos="1.23745 -1.23744 -0.750006" />
                            <Vertex pos="1.6168 -0.669693 -0.750006" />
                        </Vertices>
                        <Face id="17" plane="-0 0 -1 -1" album="Blasted" material="metal_bm" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15" />
                        </Face>
                        <Face id="18" plane="0.70022 0.139281 0.700209 -0.700231" album="Blasted" material="metal_bm" texgens="-0.195089 0.980785 0 12.4857 0.68676 0.136604 -0.713933 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 16 17 2" />
                        </Face>
                        <Face id="19" plane="0.593615 0.396647 0.700209 -0.700229" album="Blasted" material="metal_bm" texgens="-0.555576 0.831466 0 37.4578 0.582204 0.389023 -0.713933 -66.7984 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 17 18" />
                        </Face>
                        <Face id="20" plane="0.396644 0.593614 0.700211 -0.700222" album="Blasted" material="metal_bm" texgens="-0.831467 0.555574 0 62.4285 0.38902 0.582205 -0.713933 -66.7984 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 3 18 19" />
                        </Face>
                        <Face id="21" plane="0.139281 0.70022 0.700209 -0.700229" album="Blasted" material="metal_bm" texgens="-0.980786 0.195089 0 87.4006 0.136604 0.68676 -0.713933 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 19 20" />
                        </Face>
                        <Face id="22" plane="-0.139281 0.700219 0.70021 -0.700228" album="Blasted" material="metal_bm" texgens="-0.980785 -0.195089 0 112.372 -0.136604 0.68676 -0.713933 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 5 20 21" />
                        </Face>
                        <Face id="23" plane="-0.396643 0.593614 0.700212 -0.700226" album="Blasted" material="metal_bm" texgens="-0.831468 -0.555573 0 137.344 -0.38902 0.582206 -0.713932 -66.7986 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 21 22" />
                        </Face>
                        <Face id="24" plane="-0.593614 0.396645 0.700211 -0.700226" album="Blasted" material="metal_bm" texgens="-0.555575 -0.831467 0 162.315 -0.582205 0.389022 -0.713932 -66.7986 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 8 7 22 23" />
                        </Face>
                        <Face id="25" plane="-0.700221 0.139281 0.700208 -0.700234" album="Blasted" material="metal_bm" texgens="-0.195089 -0.980785 0 187.287 -0.68676 0.136604 -0.713932 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 9 8 23 24" />
                        </Face>
                        <Face id="26" plane="-0.70022 -0.139281 0.700209 -0.700231" album="Blasted" material="metal_bm" texgens="0.195089 -0.980786 0 212.258 -0.68676 -0.136604 -0.713933 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 10 9 24 25" />
                        </Face>
                        <Face id="27" plane="-0.593616 -0.396646 0.700208 -0.70023" album="Blasted" material="metal_bm" texgens="0.555575 -0.831467 0 237.23 -0.582205 -0.389021 -0.713933 -66.7984 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 11 10 25 26" />
                        </Face>
                        <Face id="28" plane="-0.396646 -0.593614 0.70021 -0.700226" album="Blasted" material="metal_bm" texgens="0.831466 -0.555576 0 262.201 -0.389022 -0.582204 -0.713933 -66.7984 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 12 11 26 27" />
                        </Face>
                        <Face id="29" plane="-0.139282 -0.700221 0.700208 -0.700233" album="Blasted" material="metal_bm" texgens="0.980786 -0.195089 0 287.173 -0.136604 -0.68676 -0.713933 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 13 12 27 28" />
                        </Face>
                        <Face id="30" plane="0.139281 -0.70022 0.700209 -0.700231" album="Blasted" material="metal_bm" texgens="0.980786 0.195089 0 312.145 0.136604 -0.68676 -0.713933 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 14 13 28 29" />
                        </Face>
                        <Face id="31" plane="0.396638 -0.593606 0.700221 -0.700196" album="Blasted" material="metal_bm" texgens="0.831468 0.555573 0 337.116 0.38902 -0.582206 -0.713933 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 15 14 29 30" />
                        </Face>
                        <Face id="32" plane="0.593621 -0.396638 0.700209 -0.700231" album="Blasted" material="metal_bm" texgens="0.555563 0.831474 0 362.089 0.58221 -0.389014 -0.713932 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 15 30 31" />
                        </Face>
                        <Face id="33" plane="0.700221 -0.139282 0.700208 -0.700233" album="Blasted" material="metal_bm" texgens="0.195091 0.980785 0 387.058 0.68676 -0.136605 -0.713932 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 31 16 1" />
                        </Face>
                        <Face id="34" plane="0 -0 1 0.750006" album="Blasted" material="metal_bm" texgens="0 1 0 12.4857 1 0 0 -66.7985 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 30 29 28 27 26 25 24 23 22 21 20 19 18 17 16" />
                        </Face>
                    </Brush>
                    <Brush id="381" owner="0" type="0" pos="-40 -12 21.5" rot="0 4.37114e-008 -1 3.14159" scale="" transform="-1 5.2108e-015 0 -40 -5.2108e-015 -1 -8.74228e-008 -12 0 -8.74228e-008 1 21.5 0 0 0 1" group="-1" locked="0" nextFaceID="18" nextVertexID="18">
                        <Vertices>
                            <Vertex pos="-9.28213e-007 9.53674e-007 0.500001" />
                            <Vertex pos="0.46194 0.191342 -6.55651e-007" />
                            <Vertex pos="0.5 -1.78814e-007 -6.55651e-007" />
                            <Vertex pos="0.353553 0.353553 -6.55651e-007" />
                            <Vertex pos="0.191339 0.46194 -6.55651e-007" />
                            <Vertex pos="-1.66578e-006 0.5 -6.55651e-007" />
                            <Vertex pos="-0.191344 0.461939 -6.55651e-007" />
                            <Vertex pos="-0.353552 0.353555 -6.55651e-007" />
                            <Vertex pos="-0.461939 0.191343 -6.55651e-007" />
                            <Vertex pos="-0.5 1.3113e-006 -6.55651e-007" />
                            <Vertex pos="-0.46194 -0.191341 -6.55651e-007" />
                            <Vertex pos="-0.353554 -0.353553 -6.55651e-007" />
                            <Vertex pos="-0.191342 -0.46194 -6.55651e-007" />
                            <Vertex pos="4.60123e-007 -0.5 -6.55651e-007" />
                            <Vertex pos="0.191343 -0.461939 -6.55651e-007" />
                            <Vertex pos="0.353554 -0.353552 -6.55651e-007" />
                            <Vertex pos="0.46194 -0.19134 -6.55651e-007" />
                        </Vertices>
                        <Face id="0" plane="0.700215 0.13928 0.700214 -0.350107" album="Blasted" material="solid_bm_black" texgens="-0.195089 0.980785 0 3.12142 0.431839 0.0858975 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0.593612 0.396643 0.700213 -0.350107" album="Blasted" material="solid_bm_black" texgens="-0.555574 0.831467 0 9.36443 0.366094 0.244619 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 1 0" />
                        </Face>
                        <Face id="2" plane="0.396638 0.593616 0.700212 -0.350107" album="Blasted" material="solid_bm_black" texgens="-0.83147 0.555569 0 15.6073 0.244616 0.366095 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 3 0" />
                        </Face>
                        <Face id="3" plane="0.139282 0.700216 0.700213 -0.350108" album="Blasted" material="solid_bm_black" texgens="-0.980786 0.195089 0 21.8501 0.0858976 0.431839 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0" />
                        </Face>
                        <Face id="4" plane="-0.139284 0.700216 0.700212 -0.350108" album="Blasted" material="solid_bm_black" texgens="-0.980785 -0.195094 0 28.0931 -0.0858996 0.431839 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 5 0" />
                        </Face>
                        <Face id="5" plane="-0.396641 0.593614 0.700213 -0.350108" album="Blasted" material="solid_bm_black" texgens="-0.831469 -0.555571 0 34.3359 -0.244617 0.366096 -0.897851 -21.2751 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 0" />
                        </Face>
                        <Face id="6" plane="-0.593614 0.396642 0.700212 -0.350108" album="Blasted" material="solid_bm_black" texgens="-0.555572 -0.831469 0 40.5788 -0.366095 0.244618 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 8 7 0" />
                        </Face>
                        <Face id="7" plane="-0.700216 0.139284 0.700212 -0.350108" album="Blasted" material="solid_bm_black" texgens="-0.195094 -0.980785 0 46.8216 -0.431839 0.0858998 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 9 8 0" />
                        </Face>
                        <Face id="8" plane="-0.700216 -0.13928 0.700213 -0.350108" album="Blasted" material="solid_bm_black" texgens="0.195089 -0.980786 0 53.0645 -0.431839 -0.0858974 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 10 9 0" />
                        </Face>
                        <Face id="9" plane="-0.593615 -0.396639 0.700213 -0.350107" album="Blasted" material="solid_bm_black" texgens="0.555568 -0.831471 0 59.3073 -0.366096 -0.244616 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 11 10 0" />
                        </Face>
                        <Face id="10" plane="-0.396641 -0.593613 0.700214 -0.350107" album="Blasted" material="solid_bm_black" texgens="0.831469 -0.555571 0 65.5503 -0.244618 -0.366095 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 12 11 0" />
                        </Face>
                        <Face id="11" plane="-0.13928 -0.700215 0.700214 -0.350107" album="Blasted" material="solid_bm_black" texgens="0.980786 -0.195088 0 71.7932 -0.0858974 -0.43184 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 13 12 0" />
                        </Face>
                        <Face id="12" plane="0.139284 -0.700215 0.700214 -0.350107" album="Blasted" material="solid_bm_black" texgens="0.980785 0.195093 0 78.036 0.0858995 -0.431839 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 14 13 0" />
                        </Face>
                        <Face id="13" plane="0.396643 -0.593612 0.700214 -0.350107" album="Blasted" material="solid_bm_black" texgens="0.831467 0.555574 0 84.2792 0.244619 -0.366094 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 15 14 0" />
                        </Face>
                        <Face id="14" plane="0.593615 -0.396638 0.700214 -0.350107" album="Blasted" material="solid_bm_black" texgens="0.555568 0.831471 0 90.5221 0.366096 -0.244616 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 16 15 0" />
                        </Face>
                        <Face id="15" plane="0.700215 -0.139282 0.700214 -0.350107" album="Blasted" material="solid_bm_black" texgens="0.195091 0.980785 0 96.7649 0.431839 -0.0858984 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 16 0 2" />
                        </Face>
                        <Face id="16" plane="-0 0 -1 -6.55651e-007" album="Blasted" material="solid_bm_black" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 16 2 1 3 4 5 6 7 8 9 10 11 12 13 14 15" />
                        </Face>
                    </Brush>
                    <Brush id="382" owner="0" type="0" pos="-40 -12 -3" rot="0 1 8.74228e-008 3.14159" scale="" transform="-1 5.2108e-015 0 -40 5.2108e-015 1 1.74846e-007 -12 4.55543e-022 1.74846e-007 -1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="18" nextVertexID="18">
                        <Vertices>
                            <Vertex pos="-9.28213e-007 9.53674e-007 0.500001" />
                            <Vertex pos="0.46194 0.191342 -6.55651e-007" />
                            <Vertex pos="0.5 -1.78814e-007 -6.55651e-007" />
                            <Vertex pos="0.353553 0.353553 -6.55651e-007" />
                            <Vertex pos="0.191339 0.46194 -6.55651e-007" />
                            <Vertex pos="-1.66578e-006 0.5 -6.55651e-007" />
                            <Vertex pos="-0.191344 0.461939 -6.55651e-007" />
                            <Vertex pos="-0.353552 0.353555 -6.55651e-007" />
                            <Vertex pos="-0.461939 0.191343 -6.55651e-007" />
                            <Vertex pos="-0.5 1.3113e-006 -6.55651e-007" />
                            <Vertex pos="-0.46194 -0.191341 -6.55651e-007" />
                            <Vertex pos="-0.353554 -0.353553 -6.55651e-007" />
                            <Vertex pos="-0.191342 -0.46194 -6.55651e-007" />
                            <Vertex pos="4.60123e-007 -0.5 -6.55651e-007" />
                            <Vertex pos="0.191343 -0.461939 -6.55651e-007" />
                            <Vertex pos="0.353554 -0.353552 -6.55651e-007" />
                            <Vertex pos="0.46194 -0.19134 -6.55651e-007" />
                        </Vertices>
                        <Face id="0" plane="0.700215 0.13928 0.700214 -0.350107" album="Blasted" material="solid_bm_black" texgens="-0.195089 0.980785 0 3.12142 0.431839 0.0858975 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0.593612 0.396643 0.700213 -0.350107" album="Blasted" material="solid_bm_black" texgens="-0.555574 0.831467 0 9.36443 0.366094 0.244619 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 1 0" />
                        </Face>
                        <Face id="2" plane="0.396638 0.593616 0.700212 -0.350107" album="Blasted" material="solid_bm_black" texgens="-0.83147 0.555569 0 15.6073 0.244616 0.366095 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 3 0" />
                        </Face>
                        <Face id="3" plane="0.139282 0.700216 0.700213 -0.350108" album="Blasted" material="solid_bm_black" texgens="-0.980786 0.195089 0 21.8501 0.0858976 0.431839 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0" />
                        </Face>
                        <Face id="4" plane="-0.139284 0.700216 0.700212 -0.350108" album="Blasted" material="solid_bm_black" texgens="-0.980785 -0.195094 0 28.0931 -0.0858996 0.431839 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 5 0" />
                        </Face>
                        <Face id="5" plane="-0.396641 0.593614 0.700213 -0.350108" album="Blasted" material="solid_bm_black" texgens="-0.831469 -0.555571 0 34.3359 -0.244617 0.366096 -0.897851 -21.2751 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 0" />
                        </Face>
                        <Face id="6" plane="-0.593614 0.396642 0.700212 -0.350108" album="Blasted" material="solid_bm_black" texgens="-0.555572 -0.831469 0 40.5788 -0.366095 0.244618 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 8 7 0" />
                        </Face>
                        <Face id="7" plane="-0.700216 0.139284 0.700212 -0.350108" album="Blasted" material="solid_bm_black" texgens="-0.195094 -0.980785 0 46.8216 -0.431839 0.0858998 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 9 8 0" />
                        </Face>
                        <Face id="8" plane="-0.700216 -0.13928 0.700213 -0.350108" album="Blasted" material="solid_bm_black" texgens="0.195089 -0.980786 0 53.0645 -0.431839 -0.0858974 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 10 9 0" />
                        </Face>
                        <Face id="9" plane="-0.593615 -0.396639 0.700213 -0.350107" album="Blasted" material="solid_bm_black" texgens="0.555568 -0.831471 0 59.3073 -0.366096 -0.244616 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 11 10 0" />
                        </Face>
                        <Face id="10" plane="-0.396641 -0.593613 0.700214 -0.350107" album="Blasted" material="solid_bm_black" texgens="0.831469 -0.555571 0 65.5503 -0.244618 -0.366095 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 12 11 0" />
                        </Face>
                        <Face id="11" plane="-0.13928 -0.700215 0.700214 -0.350107" album="Blasted" material="solid_bm_black" texgens="0.980786 -0.195088 0 71.7932 -0.0858974 -0.43184 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 13 12 0" />
                        </Face>
                        <Face id="12" plane="0.139284 -0.700215 0.700214 -0.350107" album="Blasted" material="solid_bm_black" texgens="0.980785 0.195093 0 78.036 0.0858995 -0.431839 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 14 13 0" />
                        </Face>
                        <Face id="13" plane="0.396643 -0.593612 0.700214 -0.350107" album="Blasted" material="solid_bm_black" texgens="0.831467 0.555574 0 84.2792 0.244619 -0.366094 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 15 14 0" />
                        </Face>
                        <Face id="14" plane="0.593615 -0.396638 0.700214 -0.350107" album="Blasted" material="solid_bm_black" texgens="0.555568 0.831471 0 90.5221 0.366096 -0.244616 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 16 15 0" />
                        </Face>
                        <Face id="15" plane="0.700215 -0.139282 0.700214 -0.350107" album="Blasted" material="solid_bm_black" texgens="0.195091 0.980785 0 96.7649 0.431839 -0.0858984 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 16 0 2" />
                        </Face>
                        <Face id="16" plane="-0 0 -1 -6.55651e-007" album="Blasted" material="solid_bm_black" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 16 2 1 3 4 5 6 7 8 9 10 11 12 13 14 15" />
                        </Face>
                    </Brush>
                    <Brush id="384" owner="0" type="0" pos="-40 -12 -2.5" rot="1 0 0 0" scale="" transform="1 0 0 -40 0 1 0 -12 0 0 1 -2.5 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="0.46194 0.191342 -0.5" />
                            <Vertex pos="0.461941 0.191342 24" />
                            <Vertex pos="0.5 -1.2296e-007 -0.5" />
                            <Vertex pos="0.5 0 24" />
                            <Vertex pos="0.353553 0.353553 -0.5" />
                            <Vertex pos="0.353554 0.353553 24" />
                            <Vertex pos="0.19134 0.46194 -0.5" />
                            <Vertex pos="0.191341 0.46194 24" />
                            <Vertex pos="-1.86293e-006 0.5 -0.5" />
                            <Vertex pos="0 0.5 24" />
                            <Vertex pos="-0.191344 0.461939 -0.5" />
                            <Vertex pos="-0.191345 0.461939 24" />
                            <Vertex pos="-0.353552 0.353555 -0.5" />
                            <Vertex pos="-0.353554 0.353555 24" />
                            <Vertex pos="-0.461939 0.191343 -0.5" />
                            <Vertex pos="-0.461941 0.191343 24" />
                            <Vertex pos="-0.5 1.25189e-006 -0.5" />
                            <Vertex pos="-0.5 9.53674e-007 24" />
                            <Vertex pos="-0.46194 -0.191341 -0.5" />
                            <Vertex pos="-0.461941 -0.191341 24" />
                            <Vertex pos="-0.353554 -0.353553 -0.5" />
                            <Vertex pos="-0.353554 -0.353553 24" />
                            <Vertex pos="-0.191342 -0.46194 -0.5" />
                            <Vertex pos="-0.191341 -0.46194 24" />
                            <Vertex pos="4.28482e-007 -0.5 -0.5" />
                            <Vertex pos="0 -0.5 24" />
                            <Vertex pos="0.191343 -0.461939 -0.5" />
                            <Vertex pos="0.191341 -0.461939 24" />
                            <Vertex pos="0.353554 -0.353552 -0.5" />
                            <Vertex pos="0.353554 -0.353552 24" />
                            <Vertex pos="0.46194 -0.19134 -0.5" />
                            <Vertex pos="0.461941 -0.191339 24" />
                        </Vertices>
                        <Face id="0" plane="0.980787 0.195084 -4.05637e-008 -0.490392" album="Blasted" material="solid_bm_black" texgens="-0.195089 0.980786 0 3.12142 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.831467 0.555574 -3.43881e-008 -0.490393" album="Blasted" material="solid_bm_black" texgens="-0.555574 0.831467 0 9.36443 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.555569 0.83147 -2.26395e-008 -0.490392" album="Blasted" material="solid_bm_black" texgens="-0.83147 0.555569 0 15.6073 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="0.195089 0.980786 -1.48342e-008 -0.490392" album="Blasted" material="solid_bm_black" texgens="-0.980786 0.195089 0 21.8501 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.195094 0.980785 -8.06875e-009 -0.490393" album="Blasted" material="solid_bm_black" texgens="-0.980785 -0.195094 0 28.0931 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.555571 0.831469 -4.52791e-008 -0.490393" album="Blasted" material="solid_bm_black" texgens="-0.831469 -0.55557 0 34.3359 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="-0.831469 0.555572 -6.77649e-008 -0.490393" album="Blasted" material="solid_bm_black" texgens="-0.555572 -0.831469 0 40.5788 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="-0.980784 0.195094 2.3747e-009 -0.490392" album="Blasted" material="solid_bm_black" texgens="-0.195094 -0.980785 0 46.8216 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.980786 -0.195089 -4.05636e-008 -0.490393" album="Blasted" material="solid_bm_black" texgens="0.195089 -0.980786 0 53.0645 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.831471 -0.555568 0 -0.490393" album="Blasted" material="solid_bm_black" texgens="0.555568 -0.831471 0 59.3073 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.555572 -0.831469 2.26396e-008 -0.490393" album="Blasted" material="solid_bm_black" texgens="0.831469 -0.555572 0 65.5502 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.195089 -0.980786 -3.41192e-009 -0.490393" album="Blasted" material="solid_bm_black" texgens="0.980786 -0.195088 0 71.7932 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="0.195093 -0.980785 1.59001e-008 -0.490392" album="Blasted" material="solid_bm_black" texgens="0.980785 0.195093 0 78.036 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="0.555574 -0.831467 0 -0.490392" album="Blasted" material="solid_bm_black" texgens="0.831467 0.555574 0 84.2792 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="0.831471 -0.555568 -1.17488e-008 -0.490392" album="Blasted" material="solid_bm_black" texgens="0.555568 0.831471 0 90.5221 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="0.980786 -0.195087 9.79097e-010 -0.490393" album="Blasted" material="solid_bm_black" texgens="0.195091 0.980785 0 96.7649 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 3 2 30" />
                        </Face>
                        <Face id="16" plane="-0 0 -1 -0.5" album="Blasted" material="solid_bm_black" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 30 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28" />
                        </Face>
                        <Face id="17" plane="0 -0 1 -24" album="Blasted" material="solid_bm_black" texgens="1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="385" owner="0" type="0" pos="24.125 -42 17.25" rot="1 0 0 0" scale="" transform="1 0 0 24.125 0 1 0 -42 0 0 1 17.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 8 0.25" />
                            <Vertex pos="0.125 8 -0.25" />
                            <Vertex pos="0.125 -8 0.25" />
                            <Vertex pos="0.125 -8 -0.25" />
                            <Vertex pos="-0.125 8 0.25" />
                            <Vertex pos="-0.125 8 -0.25" />
                            <Vertex pos="-0.125 -8 0.25" />
                            <Vertex pos="-0.125 -8 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white" texgens="0 1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white" texgens="0 -1 0 -1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublevert" texgens="1 0 0 32 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="386" owner="0" type="0" pos="17.875 -42 17.25" rot="1 0 0 0" scale="" transform="1 0 0 17.875 0 1 0 -42 0 0 1 17.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 4 0.25" />
                            <Vertex pos="0.125 4 -0.25" />
                            <Vertex pos="0.125 -8 0.25" />
                            <Vertex pos="0.125 -8 -0.25" />
                            <Vertex pos="-0.125 3.75 0.25" />
                            <Vertex pos="-0.125 3.75 -0.25" />
                            <Vertex pos="-0.125 -8 0.25" />
                            <Vertex pos="-0.125 -8 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white" texgens="0 1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white" texgens="0 -1 0 -1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -2.74004" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublevert" texgens="1 0 0 32 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="387" owner="0" type="0" pos="-1.875 -26 17.25" rot="1 0 0 0" scale="" transform="1 0 0 -1.875 0 1 0 -26 0 0 1 17.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 2.25 0.25" />
                            <Vertex pos="0.125 2.25 -0.25" />
                            <Vertex pos="0.125 -2.25 0.25" />
                            <Vertex pos="0.125 -2.25 -0.25" />
                            <Vertex pos="-0.125 2.25 0.25" />
                            <Vertex pos="-0.125 2.25 -0.25" />
                            <Vertex pos="-0.125 -2.25 0.25" />
                            <Vertex pos="-0.125 -2.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 1 0 -6656 0 0 -1 -4416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 -1 0 6656 0 0 -1 -4416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.25" album="Blasted" material="bm_trim" texgens="-1 0 0 480 0 0 -1 -4416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.25" album="Blasted" material="bm_trim" texgens="1 0 0 -480 0 0 -1 -4416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 -480 0 -1 0 6656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 480 0 -1 0 6656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="388" owner="0" type="0" pos="13 -38.125 17.25" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 -38.125 0 0 1 17.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.125 0.25" />
                            <Vertex pos="5 0.125 -0.25" />
                            <Vertex pos="4.75 -0.125 0.25" />
                            <Vertex pos="4.75 -0.125 -0.25" />
                            <Vertex pos="-3 0.125 0.25" />
                            <Vertex pos="-3 0.125 -0.25" />
                            <Vertex pos="-3 -0.125 0.25" />
                            <Vertex pos="-3 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -3.44715" album="" material="bm_edge_white_doublevert" texgens="0 1 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 256 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 -128 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="389" owner="0" type="0" pos="9.875 -41 17.25" rot="1 0 0 0" scale="" transform="1 0 0 9.875 0 1 0 -41 0 0 1 17.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 7.25 0.25" />
                            <Vertex pos="0.125 7.25 -0.25" />
                            <Vertex pos="0.125 2.75 0.25" />
                            <Vertex pos="0.125 2.75 -0.25" />
                            <Vertex pos="-0.125 7.25 0.25" />
                            <Vertex pos="-0.125 7.25 -0.25" />
                            <Vertex pos="-0.125 2.75 0.25" />
                            <Vertex pos="-0.125 2.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 1 0 -10496 0 0 -1 -4416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 -1 0 10496 0 0 -1 -4416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -7.25" album="Blasted" material="bm_trim" texgens="-1 0 0 -2528 0 0 -1 -4416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 2.75" album="Blasted" material="bm_trim" texgens="1 0 0 2528 0 0 -1 -4416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 2528 0 -1 0 10496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 -2528 0 -1 0 10496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="390" owner="0" type="0" pos="13.5 -33.875 17.25" rot="1 0 0 0" scale="" transform="1 0 0 13.5 0 1 0 -33.875 0 0 1 17.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.125 0.25" />
                            <Vertex pos="0.5 0.125 -0.25" />
                            <Vertex pos="0.5 -0.125 0.25" />
                            <Vertex pos="0.5 -0.125 -0.25" />
                            <Vertex pos="-3.5 0.125 0.25" />
                            <Vertex pos="-3.5 0.125 -0.25" />
                            <Vertex pos="-3.5 -0.125 0.25" />
                            <Vertex pos="-3.5 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_trim" texgens="0 1 0 -8672 0 0 -1 -4416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.5" album="Blasted" material="bm_trim" texgens="0 -1 0 8672 0 0 -1 -4416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_trim" texgens="-1 0 0 -3456 0 0 -1 -4416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="Blasted" material="bm_trim" texgens="1 0 0 3456 0 0 -1 -4416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 3456 0 -1 0 8672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 -3456 0 -1 0 8672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="391" owner="0" type="0" pos="18 -33.875 17.25" rot="1 0 0 0" scale="" transform="1 0 0 18 0 1 0 -33.875 0 0 1 17.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.5 0.125 0.25" />
                            <Vertex pos="-0.5 0.125 -0.25" />
                            <Vertex pos="-0.5 -0.125 0.25" />
                            <Vertex pos="-0.5 -0.125 -0.25" />
                            <Vertex pos="-4 0.125 0.25" />
                            <Vertex pos="-4 0.125 -0.25" />
                            <Vertex pos="-4 -0.125 0.25" />
                            <Vertex pos="-4 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 0.5" album="" material="bm_edge_white_doublevert" texgens="0 1 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -288 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 -512 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 640 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="393" owner="0" type="0" pos="-20.125 -31 16.25" rot="1 0 0 0" scale="" transform="1 0 0 -20.125 0 1 0 -31 0 0 1 16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 7.25 0.25" />
                            <Vertex pos="0.125 7.25 -0.25" />
                            <Vertex pos="0.125 2.75 0.25" />
                            <Vertex pos="0.125 2.75 -0.25" />
                            <Vertex pos="-0.125 7.25 0.25" />
                            <Vertex pos="-0.125 7.25 -0.25" />
                            <Vertex pos="-0.125 2.75 0.25" />
                            <Vertex pos="-0.125 2.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 1 0 -7936 0 0 -1 -4160 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 -1 0 7936 0 0 -1 -4160 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -7.25" album="Blasted" material="bm_trim" texgens="-1 0 0 5152 0 0 -1 -4160 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 2.75" album="Blasted" material="bm_trim" texgens="1 0 0 -5152 0 0 -1 -4160 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 -5152 0 -1 0 7936 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 5152 0 -1 0 7936 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="394" owner="0" type="0" pos="-23.875 -24 16.25" rot="1 0 0 0" scale="" transform="1 0 0 -23.875 0 1 0 -24 0 0 1 16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 2.25 0.25" />
                            <Vertex pos="0.125 2.25 -0.25" />
                            <Vertex pos="0.125 -2.25 0.25" />
                            <Vertex pos="0.125 -2.25 -0.25" />
                            <Vertex pos="-0.125 2.25 0.25" />
                            <Vertex pos="-0.125 2.25 -0.25" />
                            <Vertex pos="-0.125 -2.25 0.25" />
                            <Vertex pos="-0.125 -2.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 1 0 -6144 0 0 -1 -4160 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 -1 0 6144 0 0 -1 -4160 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.25" album="Blasted" material="bm_trim" texgens="-1 0 0 6112 0 0 -1 -4160 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.25" album="Blasted" material="bm_trim" texgens="1 0 0 -6112 0 0 -1 -4160 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 -6112 0 -1 0 6144 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 6112 0 -1 0 6144 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="395" owner="0" type="0" pos="-34.125 -31 16.25" rot="1 0 0 0" scale="" transform="1 0 0 -34.125 0 1 0 -31 0 0 1 16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 7 0.25" />
                            <Vertex pos="0.125 7 -0.25" />
                            <Vertex pos="0.125 5 0.25" />
                            <Vertex pos="0.125 5 -0.25" />
                            <Vertex pos="-0.125 7 0.25" />
                            <Vertex pos="-0.125 7 -0.25" />
                            <Vertex pos="-0.125 5 0.25" />
                            <Vertex pos="-0.125 5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white" texgens="0 1 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white" texgens="0 -1 0 -1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -7" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 5" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublevert" texgens="1 0 0 32 0 -1 0 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 -1 0 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="396" owner="0" type="0" pos="-34.125 -26.125 16.25" rot="1 0 0 0" scale="" transform="1 0 0 -34.125 0 1 0 -26.125 0 0 1 16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.125 0.25" />
                            <Vertex pos="0.125 0.125 -0.25" />
                            <Vertex pos="0.125 -0.125 0.25" />
                            <Vertex pos="0.125 -0.125 -0.25" />
                            <Vertex pos="-0.125 0.125 0.25" />
                            <Vertex pos="-0.125 0.125 -0.25" />
                            <Vertex pos="-0.125 -0.125 0.25" />
                            <Vertex pos="-0.125 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white_doublevert" texgens="0 1 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -288 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_half" texgens="1 0 0 32 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="64 64">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_half" texgens="-1 0 0 96 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="64 64">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="397" owner="0" type="0" pos="-49 -0.125 17.25" rot="1 0 0 0" scale="" transform="1 0 0 -49 0 1 0 -0.125 0 0 1 17.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3 0.125 0.25" />
                            <Vertex pos="-3 0.125 -0.25" />
                            <Vertex pos="-3 -0.125 0.25" />
                            <Vertex pos="-3 -0.125 -0.25" />
                            <Vertex pos="-5 0.125 0.25" />
                            <Vertex pos="-5 0.125 -0.25" />
                            <Vertex pos="-5 -0.125 0.25" />
                            <Vertex pos="-5 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 3" album="" material="bm_edge_white_doublevert" texgens="0 1 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 256 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 -128 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="398" owner="0" type="0" pos="-54.125 -0.125 17.25" rot="1 0 0 0" scale="" transform="1 0 0 -54.125 0 1 0 -0.125 0 0 1 17.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.125 0.25" />
                            <Vertex pos="0.125 0.125 -0.25" />
                            <Vertex pos="0.125 -0.125 0.25" />
                            <Vertex pos="0.125 -0.125 -0.25" />
                            <Vertex pos="-0.125 0.125 0.25" />
                            <Vertex pos="-0.125 0.125 -0.25" />
                            <Vertex pos="-0.125 -0.125 0.25" />
                            <Vertex pos="-0.125 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white_doublevert" texgens="0 1 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -288 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_half" texgens="1 0 0 32 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="64 64">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_half" texgens="-1 0 0 96 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="64 64">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="399" owner="0" type="0" pos="-56.5 8.125 17.25" rot="1 0 0 0" scale="" transform="1 0 0 -56.5 0 1 0 8.125 0 0 1 17.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.75 0.125 0.25" />
                            <Vertex pos="6.75 0.125 -0.25" />
                            <Vertex pos="6.75 -0.125 0.25" />
                            <Vertex pos="6.75 -0.125 -0.25" />
                            <Vertex pos="2.25 0.125 0.25" />
                            <Vertex pos="2.25 0.125 -0.25" />
                            <Vertex pos="2.25 -0.125 0.25" />
                            <Vertex pos="2.25 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.75" album="Blasted" material="bm_trim" texgens="0 1 0 2080 0 0 -1 -4416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.25" album="Blasted" material="bm_trim" texgens="0 -1 0 -2080 0 0 -1 -4416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_trim" texgens="-1 0 0 14464 0 0 -1 -4416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="Blasted" material="bm_trim" texgens="1 0 0 -14464 0 0 -1 -4416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 -14464 0 -1 0 -2080 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 14464 0 -1 0 -2080 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="400" owner="0" type="0" pos="-45.125 23 18.75" rot="1 0 0 0" scale="" transform="1 0 0 -45.125 0 1 0 23 0 0 1 18.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 7.25 0.25" />
                            <Vertex pos="0.125 7.25 -0.25" />
                            <Vertex pos="0.125 2.75 0.25" />
                            <Vertex pos="0.125 2.75 -0.25" />
                            <Vertex pos="-0.125 7.25 0.25" />
                            <Vertex pos="-0.125 7.25 -0.25" />
                            <Vertex pos="-0.125 2.75 0.25" />
                            <Vertex pos="-0.125 2.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 1 0 5888 0 0 -1 -4800 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 -1 0 -5888 0 0 -1 -4800 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -7.25" album="Blasted" material="bm_trim" texgens="-1 0 0 11552 0 0 -1 -4800 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 2.75" album="Blasted" material="bm_trim" texgens="1 0 0 -11552 0 0 -1 -4800 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 -11552 0 -1 0 -5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 11552 0 -1 0 -5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="401" owner="0" type="0" pos="-29.125 23 17.75" rot="1 0 0 0" scale="" transform="1 0 0 -29.125 0 1 0 23 0 0 1 17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 7.25 0.25" />
                            <Vertex pos="0.125 7.25 -0.25" />
                            <Vertex pos="0.125 2.75 0.25" />
                            <Vertex pos="0.125 2.75 -0.25" />
                            <Vertex pos="-0.125 7.25 0.25" />
                            <Vertex pos="-0.125 7.25 -0.25" />
                            <Vertex pos="-0.125 2.75 0.25" />
                            <Vertex pos="-0.125 2.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 1 0 5888 0 0 -1 -4544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 -1 0 -5888 0 0 -1 -4544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -7.25" album="Blasted" material="bm_trim" texgens="-1 0 0 7456 0 0 -1 -4544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 2.75" album="Blasted" material="bm_trim" texgens="1 0 0 -7456 0 0 -1 -4544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 -7456 0 -1 0 -5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 7456 0 -1 0 -5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="402" owner="0" type="0" pos="-32.875 28 17.75" rot="1 0 0 0" scale="" transform="1 0 0 -32.875 0 1 0 28 0 0 1 17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 2.25 0.25" />
                            <Vertex pos="0.125 2.25 -0.25" />
                            <Vertex pos="0.125 -2.25 0.25" />
                            <Vertex pos="0.125 -2.25 -0.25" />
                            <Vertex pos="-0.125 2.25 0.25" />
                            <Vertex pos="-0.125 2.25 -0.25" />
                            <Vertex pos="-0.125 -2.25 0.25" />
                            <Vertex pos="-0.125 -2.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 1 0 7168 0 0 -1 -4544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 -1 0 -7168 0 0 -1 -4544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.25" album="Blasted" material="bm_trim" texgens="-1 0 0 8416 0 0 -1 -4544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.25" album="Blasted" material="bm_trim" texgens="1 0 0 -8416 0 0 -1 -4544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 -8416 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 8416 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="403" owner="0" type="0" pos="-16.875 28 18.75" rot="1 0 0 0" scale="" transform="1 0 0 -16.875 0 1 0 28 0 0 1 18.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 2.25 0.25" />
                            <Vertex pos="0.125 2.25 -0.25" />
                            <Vertex pos="0.125 -2.25 0.25" />
                            <Vertex pos="0.125 -2.25 -0.25" />
                            <Vertex pos="-0.125 2.25 0.25" />
                            <Vertex pos="-0.125 2.25 -0.25" />
                            <Vertex pos="-0.125 -2.25 0.25" />
                            <Vertex pos="-0.125 -2.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 1 0 7168 0 0 -1 -4800 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="Blasted" material="bm_trim" texgens="0 -1 0 -7168 0 0 -1 -4800 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.25" album="Blasted" material="bm_trim" texgens="-1 0 0 4320 0 0 -1 -4800 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.25" album="Blasted" material="bm_trim" texgens="1 0 0 -4320 0 0 -1 -4800 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 -4320 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 4320 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="404" owner="0" type="0" pos="21.5 -50.125 17.25" rot="1 0 0 0" scale="" transform="1 0 0 21.5 0 1 0 -50.125 0 0 1 17.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.75 0.125 0.25" />
                            <Vertex pos="2.75 0.125 -0.25" />
                            <Vertex pos="2.75 -0.125 0.25" />
                            <Vertex pos="2.75 -0.125 -0.25" />
                            <Vertex pos="-3.75 0.125 0.25" />
                            <Vertex pos="-3.75 0.125 -0.25" />
                            <Vertex pos="-3.75 -0.125 0.25" />
                            <Vertex pos="-3.75 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.75" album="Blasted" material="bm_trim" texgens="0 1 0 -12832 0 0 -1 -4416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.75" album="Blasted" material="bm_trim" texgens="0 -1 0 12832 0 0 -1 -4416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_trim" texgens="-1 0 0 -5504 0 0 -1 -4416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="Blasted" material="bm_trim" texgens="1 0 0 5504 0 0 -1 -4416 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 5504 0 -1 0 12832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 -5504 0 -1 0 12832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="405" owner="0" type="0" pos="13 -32 17.75" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 -32 0 0 1 17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="11 -1.5 1.75" />
                            <Vertex pos="11 -1.5 -0.25" />
                            <Vertex pos="11 -2 1.75" />
                            <Vertex pos="11 -2 -0.25" />
                            <Vertex pos="5 -1.5 3.75" />
                            <Vertex pos="5 -1.5 -0.25" />
                            <Vertex pos="5 -2 3.75" />
                            <Vertex pos="5 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -11" album="" material="bm_grid_blank2" texgens="0 1 0 256 0 0 -1 224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 5" album="" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 1.5" album="" material="bm_grid_blank2" texgens="-1 0 0 896 0 0 -1 224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_friction_sand" texgens="1 0 0 3328 0 0 -1 -4544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.316228 0 0.948683 -5.1387" album="Blasted" material="bm_friction_sand" texgens="1 0 0 3328 0 -1 0 8192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 -640 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="410" owner="0" type="0" pos="13 -34 21.25" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 -34 0 0 1 21.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="11 2 -1.75" />
                            <Vertex pos="11 2 -2.25" />
                            <Vertex pos="11 0.5 -1.75" />
                            <Vertex pos="11 0.5 -2.25" />
                            <Vertex pos="5 2 0.25" />
                            <Vertex pos="5 2 -0.25" />
                            <Vertex pos="5 0.5 0.25" />
                            <Vertex pos="5 0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -11" album="" material="bm_grid_blank2" texgens="0 1 0 0 0 0 -1 -480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 5" album="" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 0.5" album="" material="bm_edge_white" texgens="1 0 0 1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.316228 0 0.948683 -1.81831" album="Blasted" material="bm_friction_sand" texgens="1 0 0 3328 0 -1 0 8704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.316228 0 -0.948683 1.34397" album="" material="bm_grid_blank2" texgens="-1 0 0 -640 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="414" owner="0" type="0" pos="24.125 -41.5 17.75" rot="1 0 0 0" scale="" transform="1 0 0 24.125 0 1 0 -41.5 0 0 1 17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 8 1.75" />
                            <Vertex pos="0.125 8 -0.75" />
                            <Vertex pos="0.125 7.5 1.75" />
                            <Vertex pos="0.125 7.5 -0.75" />
                            <Vertex pos="-0.125 8 1.75" />
                            <Vertex pos="-0.125 8 -0.75" />
                            <Vertex pos="-0.125 7.5 1.75" />
                            <Vertex pos="-0.125 7.5 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white" texgens="0 1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white" texgens="0 -1 0 -1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 7.5" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.75" album="" material="bm_edge_white_doublevert" texgens="1 0 0 32 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.75" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="415" owner="0" type="0" pos="24.125 -41 17.75" rot="1 0 0 0" scale="" transform="1 0 0 24.125 0 1 0 -41 0 0 1 17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 9.5 1.75" />
                            <Vertex pos="0.125 9.5 1.25" />
                            <Vertex pos="0.125 7.5 1.75" />
                            <Vertex pos="0.125 7.5 1.25" />
                            <Vertex pos="-0.125 9.5 1.75" />
                            <Vertex pos="-0.125 9.5 1.25" />
                            <Vertex pos="-0.125 7.5 1.75" />
                            <Vertex pos="-0.125 7.5 1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white" texgens="0 1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white" texgens="0 -1 0 -1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -9.5" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 7.5" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.75" album="" material="bm_edge_white_doublevert" texgens="1 0 0 32 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 1.25" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="421" owner="0" type="0" pos="13 -30 21.75" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 -30 0 0 1 21.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="11 -1.5 -0.25" />
                            <Vertex pos="11 -1.5 -2.25" />
                            <Vertex pos="11 -2 -0.25" />
                            <Vertex pos="11 -2 -2.25" />
                            <Vertex pos="5 -1.5 1.75" />
                            <Vertex pos="5 -1.5 -0.25" />
                            <Vertex pos="5 -2 1.75" />
                            <Vertex pos="5 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -11" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 5" album="" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 1.5" album="" material="bm_grid_blank2" texgens="-1 0 0 896 -0.333333 0 -1 437.333 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank2" texgens="1 0 0 -1152 -0.333333 0 -1 437.333 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.316228 0 0.948683 -3.24133" album="" material="bm_edge_white" texgens="1 0 0 1792 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.316228 0 -0.948683 1.34397" album="" material="bm_edge_white" texgens="-1 0 0 1408 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="429" owner="0" type="0" pos="17.875 -32.5 21.25" rot="1 0 0 0" scale="" transform="1 0 0 17.875 0 1 0 -32.5 0 0 1 21.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 1 0.25" />
                            <Vertex pos="0.125 1 -0.25" />
                            <Vertex pos="0.125 -1.5 0.25" />
                            <Vertex pos="0.125 -1.5 -0.25" />
                            <Vertex pos="-0.125 1 0.25" />
                            <Vertex pos="-0.125 1 -0.25" />
                            <Vertex pos="-0.125 -1.5 0.25" />
                            <Vertex pos="-0.125 -1.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white" texgens="0 -1 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.5" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublevert" texgens="1 0 0 32 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="430" owner="0" type="0" pos="17.875 -32.5 22.75" rot="1 0 0 0" scale="" transform="1 0 0 17.875 0 1 0 -32.5 0 0 1 22.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 -1 -1.75" />
                            <Vertex pos="0.125 -1 -5.75" />
                            <Vertex pos="0.125 -1.5 -1.75" />
                            <Vertex pos="0.125 -1.5 -5.75" />
                            <Vertex pos="-0.125 -1 -1.75" />
                            <Vertex pos="-0.125 -1 -5.75" />
                            <Vertex pos="-0.125 -1.5 -1.75" />
                            <Vertex pos="-0.125 -1.5 -5.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white" texgens="0 -1 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 1" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.5" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 1.75" album="" material="bm_edge_white_doublevert" texgens="1 0 0 32 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -5.75" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="431" owner="0" type="0" pos="17 -32 17.25" rot="1 0 0 0" scale="" transform="1 0 0 17 0 1 0 -32 0 0 1 17.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 -1.5 0.25" />
                            <Vertex pos="7 -1.5 -0.25" />
                            <Vertex pos="7 -2 0.25" />
                            <Vertex pos="7 -2 -0.25" />
                            <Vertex pos="1 -1.5 0.25" />
                            <Vertex pos="1 -1.5 -0.25" />
                            <Vertex pos="1 -2 0.25" />
                            <Vertex pos="1 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -7" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 1" album="" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 1.5" album="" material="bm_edge_white" texgens="-1 0 0 -1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1792 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1408 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="432" owner="0" type="0" pos="17.625 -33.875 17.25" rot="1 0 0 0" scale="" transform="1 0 0 17.625 0 1 0 -33.875 0 0 1 17.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.125 0.25" />
                            <Vertex pos="0.125 0.125 -0.25" />
                            <Vertex pos="0.125 -0.125 0.25" />
                            <Vertex pos="0.125 -0.125 -0.25" />
                            <Vertex pos="-0.125 0.125 0.25" />
                            <Vertex pos="-0.125 0.125 -0.25" />
                            <Vertex pos="-0.125 -0.125 0.25" />
                            <Vertex pos="-0.125 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white_doublevert" texgens="0 1 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -288 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_half" texgens="1 0 0 32 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="64 64">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_half" texgens="-1 0 0 96 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="64 64">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="433" owner="0" type="0" pos="17.875 -30.5 23.75" rot="1 0 0 0" scale="" transform="1 0 0 17.875 0 1 0 -30.5 0 0 1 23.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 -1 0.25" />
                            <Vertex pos="0.125 -1 -2.25" />
                            <Vertex pos="0.125 -1.5 0.25" />
                            <Vertex pos="0.125 -1.5 -2.25" />
                            <Vertex pos="-0.125 -1 0.25" />
                            <Vertex pos="-0.125 -1 -2.25" />
                            <Vertex pos="-0.125 -1.5 0.25" />
                            <Vertex pos="-0.125 -1.5 -2.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white" texgens="0 -1 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 1" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.5" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublevert" texgens="1 0 0 32 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2.25" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="434" owner="0" type="0" pos="11.5 -28.5 23.75" rot="1 0 0 0" scale="" transform="1 0 0 11.5 0 1 0 -28.5 0 0 1 23.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12.5 -3 -1.75" />
                            <Vertex pos="12.5 -3 -2.25" />
                            <Vertex pos="12.5 -3.5 -1.75" />
                            <Vertex pos="12.5 -3.5 -2.25" />
                            <Vertex pos="6.5 -3 0.25" />
                            <Vertex pos="6.5 -3 -0.25" />
                            <Vertex pos="6.5 -3.5 0.25" />
                            <Vertex pos="6.5 -3.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12.5" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 6.5" album="" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3" album="" material="bm_edge_white" texgens="-1 0 0 1792 -0.333333 0 -1 618.666 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3.5" album="" material="bm_edge_white" texgens="1 0 0 -3072 -0.333333 0 -1 618.666 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.316228 0 0.948683 -2.29265" album="" material="bm_edge_white" texgens="1 0 0 1792 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.316228 0 -0.948683 1.81831" album="" material="bm_edge_white" texgens="-1 0 0 1408 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="437" owner="0" type="0" pos="-12.125 52 20.25" rot="1 0 0 0" scale="" transform="1 0 0 -12.125 0 1 0 52 0 0 1 20.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 8 0.25" />
                            <Vertex pos="0.125 8 -0.25" />
                            <Vertex pos="0.125 -4 0.25" />
                            <Vertex pos="0.125 -4 -0.25" />
                            <Vertex pos="-0.125 8 0.25" />
                            <Vertex pos="-0.125 8 -0.25" />
                            <Vertex pos="-0.125 -4 0.25" />
                            <Vertex pos="-0.125 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white" texgens="0 1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white" texgens="0 -1 0 -1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublevert" texgens="1 0 0 32 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="443" owner="0" type="0" pos="-10.5 60.125 20.25" rot="1 0 0 0" scale="" transform="1 0 0 -10.5 0 1 0 60.125 0 0 1 20.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.75 0.125 0.25" />
                            <Vertex pos="2.75 0.125 -0.25" />
                            <Vertex pos="2.75 -0.125 0.25" />
                            <Vertex pos="2.75 -0.125 -0.25" />
                            <Vertex pos="-1.75 0.125 0.25" />
                            <Vertex pos="-1.75 0.125 -0.25" />
                            <Vertex pos="-1.75 -0.125 0.25" />
                            <Vertex pos="-1.75 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.75" album="Blasted" material="bm_trim" texgens="0 1 0 15392 0 0 -1 -5184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.75" album="Blasted" material="bm_trim" texgens="0 -1 0 -15392 0 0 -1 -5184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_trim" texgens="-1 0 0 2688 0 0 -1 -5184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="Blasted" material="bm_trim" texgens="1 0 0 -2688 0 0 -1 -5184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 -2688 0 -1 0 -15392 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 2688 0 -1 0 -15392 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="445" owner="0" type="0" pos="-8.5 82.875 20.25" rot="1 0 0 0" scale="" transform="1 0 0 -8.5 0 1 0 82.875 0 0 1 20.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.75 0.125 0.25" />
                            <Vertex pos="0.75 0.125 -0.25" />
                            <Vertex pos="0.75 -0.125 0.25" />
                            <Vertex pos="0.75 -0.125 -0.25" />
                            <Vertex pos="-3.75 0.125 0.25" />
                            <Vertex pos="-3.75 0.125 -0.25" />
                            <Vertex pos="-3.75 -0.125 0.25" />
                            <Vertex pos="-3.75 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.75" album="Blasted" material="bm_trim" texgens="0 1 0 21216 0 0 -1 -5184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.75" album="Blasted" material="bm_trim" texgens="0 -1 0 -21216 0 0 -1 -5184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_trim" texgens="-1 0 0 2176 0 0 -1 -5184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="Blasted" material="bm_trim" texgens="1 0 0 -2176 0 0 -1 -5184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 -2176 0 -1 0 -21216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 2176 0 -1 0 -21216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="446" owner="0" type="0" pos="-8.5 91.125 20.25" rot="1 0 0 0" scale="" transform="1 0 0 -8.5 0 1 0 91.125 0 0 1 20.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.75 0.125 0.25" />
                            <Vertex pos="0.75 0.125 -0.25" />
                            <Vertex pos="0.75 -0.125 0.25" />
                            <Vertex pos="0.75 -0.125 -0.25" />
                            <Vertex pos="-3.75 0.125 0.25" />
                            <Vertex pos="-3.75 0.125 -0.25" />
                            <Vertex pos="-3.75 -0.125 0.25" />
                            <Vertex pos="-3.75 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.75" album="Blasted" material="bm_trim" texgens="0 1 0 23328 0 0 -1 -5184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.75" album="Blasted" material="bm_trim" texgens="0 -1 0 -23328 0 0 -1 -5184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_trim" texgens="-1 0 0 2176 0 0 -1 -5184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="Blasted" material="bm_trim" texgens="1 0 0 -2176 0 0 -1 -5184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 -2176 0 -1 0 -23328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 2176 0 -1 0 -23328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="447" owner="0" type="0" pos="-7.875 87 20.25" rot="1 0 0 0" scale="" transform="1 0 0 -7.875 0 1 0 87 0 0 1 20.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 4 0.25" />
                            <Vertex pos="0.125 4 -0.25" />
                            <Vertex pos="0.125 -4 0.25" />
                            <Vertex pos="0.125 -4 -0.25" />
                            <Vertex pos="-0.125 4 0.25" />
                            <Vertex pos="-0.125 4 -0.25" />
                            <Vertex pos="-0.125 -4 0.25" />
                            <Vertex pos="-0.125 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white" texgens="0 1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white" texgens="0 -1 0 -1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublevert" texgens="1 0 0 32 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="448" owner="0" type="0" pos="-12.125 87 20.25" rot="1 0 0 0" scale="" transform="1 0 0 -12.125 0 1 0 87 0 0 1 20.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 4 0.25" />
                            <Vertex pos="0.125 4 -0.25" />
                            <Vertex pos="0.125 -4 0.25" />
                            <Vertex pos="0.125 -4 -0.25" />
                            <Vertex pos="-0.125 4 0.25" />
                            <Vertex pos="-0.125 4 -0.25" />
                            <Vertex pos="-0.125 -4 0.25" />
                            <Vertex pos="-0.125 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white" texgens="0 1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white" texgens="0 -1 0 -1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublevert" texgens="1 0 0 32 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="449" owner="0" type="0" pos="-8.5 146.875 20.25" rot="1 0 0 0" scale="" transform="1 0 0 -8.5 0 1 0 146.875 0 0 1 20.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.75 0.125 0.25" />
                            <Vertex pos="0.75 0.125 -0.25" />
                            <Vertex pos="0.75 -0.125 0.25" />
                            <Vertex pos="0.75 -0.125 -0.25" />
                            <Vertex pos="-3.75 0.125 0.25" />
                            <Vertex pos="-3.75 0.125 -0.25" />
                            <Vertex pos="-3.75 -0.125 0.25" />
                            <Vertex pos="-3.75 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.75" album="Blasted" material="bm_trim" texgens="0 1 0 37600 0 0 -1 -5184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.75" album="Blasted" material="bm_trim" texgens="0 -1 0 -37600 0 0 -1 -5184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_trim" texgens="-1 0 0 2176 0 0 -1 -5184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="Blasted" material="bm_trim" texgens="1 0 0 -2176 0 0 -1 -5184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 -2176 0 -1 0 -37600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 2176 0 -1 0 -37600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="450" owner="0" type="0" pos="-8.5 159.125 20.25" rot="1 0 0 0" scale="" transform="1 0 0 -8.5 0 1 0 159.125 0 0 1 20.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.75 0.125 0.25" />
                            <Vertex pos="0.75 0.125 -0.25" />
                            <Vertex pos="0.75 -0.125 0.25" />
                            <Vertex pos="0.75 -0.125 -0.25" />
                            <Vertex pos="-3.75 0.125 0.25" />
                            <Vertex pos="-3.75 0.125 -0.25" />
                            <Vertex pos="-3.75 -0.125 0.25" />
                            <Vertex pos="-3.75 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.75" album="Blasted" material="bm_trim" texgens="0 1 0 40736 0 0 -1 -5184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.75" album="Blasted" material="bm_trim" texgens="0 -1 0 -40736 0 0 -1 -5184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_trim" texgens="-1 0 0 2176 0 0 -1 -5184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="Blasted" material="bm_trim" texgens="1 0 0 -2176 0 0 -1 -5184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 -2176 0 -1 0 -40736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 2176 0 -1 0 -40736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="451" owner="0" type="0" pos="-7.875 151 20.25" rot="1 0 0 0" scale="" transform="1 0 0 -7.875 0 1 0 151 0 0 1 20.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 8 0.25" />
                            <Vertex pos="0.125 8 -0.25" />
                            <Vertex pos="0.125 -4 0.25" />
                            <Vertex pos="0.125 -4 -0.25" />
                            <Vertex pos="-0.125 8 0.25" />
                            <Vertex pos="-0.125 8 -0.25" />
                            <Vertex pos="-0.125 -4 0.25" />
                            <Vertex pos="-0.125 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white" texgens="0 1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white" texgens="0 -1 0 -1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublevert" texgens="1 0 0 32 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="461" owner="0" type="0" pos="-8.5 181.875 20.25" rot="1 0 0 0" scale="" transform="1 0 0 -8.5 0 1 0 181.875 0 0 1 20.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.75 0.125 0.25" />
                            <Vertex pos="0.75 0.125 -0.25" />
                            <Vertex pos="0.75 -0.125 0.25" />
                            <Vertex pos="0.75 -0.125 -0.25" />
                            <Vertex pos="-3.75 0.125 0.25" />
                            <Vertex pos="-3.75 0.125 -0.25" />
                            <Vertex pos="-3.75 -0.125 0.25" />
                            <Vertex pos="-3.75 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.75" album="Blasted" material="bm_trim" texgens="0 1 0 46560 0 0 -1 -5184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.75" album="Blasted" material="bm_trim" texgens="0 -1 0 -46560 0 0 -1 -5184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_trim" texgens="-1 0 0 2176 0 0 -1 -5184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="Blasted" material="bm_trim" texgens="1 0 0 -2176 0 0 -1 -5184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 -2176 0 -1 0 -46560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 2176 0 -1 0 -46560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="462" owner="0" type="0" pos="-7.875 186 20.25" rot="1 0 0 0" scale="" transform="1 0 0 -7.875 0 1 0 186 0 0 1 20.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 4 0.25" />
                            <Vertex pos="0.125 4 -0.25" />
                            <Vertex pos="0.125 -4 0.25" />
                            <Vertex pos="0.125 -4 -0.25" />
                            <Vertex pos="-0.125 4 0.25" />
                            <Vertex pos="-0.125 4 -0.25" />
                            <Vertex pos="-0.125 -4 0.25" />
                            <Vertex pos="-0.125 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white" texgens="0 1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white" texgens="0 -1 0 -1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublevert" texgens="1 0 0 32 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="463" owner="0" type="0" pos="-12.125 186 20.25" rot="1 0 0 0" scale="" transform="1 0 0 -12.125 0 1 0 186 0 0 1 20.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 4 0.25" />
                            <Vertex pos="0.125 4 -0.25" />
                            <Vertex pos="0.125 -4 0.25" />
                            <Vertex pos="0.125 -4 -0.25" />
                            <Vertex pos="-0.125 4 0.25" />
                            <Vertex pos="-0.125 4 -0.25" />
                            <Vertex pos="-0.125 -4 0.25" />
                            <Vertex pos="-0.125 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white" texgens="0 1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white" texgens="0 -1 0 -1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublevert" texgens="1 0 0 32 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="464" owner="0" type="0" pos="-10 190.125 20.25" rot="1 0 0 0" scale="" transform="1 0 0 -10 0 1 0 190.125 0 0 1 20.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 0.25" />
                            <Vertex pos="2 0.125 -0.25" />
                            <Vertex pos="2 -0.125 0.25" />
                            <Vertex pos="2 -0.125 -0.25" />
                            <Vertex pos="-2 0.125 0.25" />
                            <Vertex pos="-2 0.125 -0.25" />
                            <Vertex pos="-2 -0.125 0.25" />
                            <Vertex pos="-2 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 1 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -288 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white" texgens="-1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="1 0 0 -1536 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublehoriz" texgens="-1 0 0 1664 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="465" owner="0" type="0" pos="-14 190.125 20.25" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 190.125 0 0 1 20.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 0.25" />
                            <Vertex pos="2 0.125 -0.25" />
                            <Vertex pos="2 -0.125 0.25" />
                            <Vertex pos="2 -0.125 -0.25" />
                            <Vertex pos="1.75 0.125 0.25" />
                            <Vertex pos="1.75 0.125 -0.25" />
                            <Vertex pos="1.75 -0.125 0.25" />
                            <Vertex pos="1.75 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 1 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 1.75" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -288 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_half" texgens="1 0 0 -1536 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="64 64">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_half" texgens="-1 0 0 1664 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="64 64">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="466" owner="0" type="0" pos="-9.75 190.125 20.25" rot="1 0 0 0" scale="" transform="1 0 0 -9.75 0 1 0 190.125 0 0 1 20.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 0.25" />
                            <Vertex pos="2 0.125 -0.25" />
                            <Vertex pos="2 -0.125 0.25" />
                            <Vertex pos="2 -0.125 -0.25" />
                            <Vertex pos="1.75 0.125 0.25" />
                            <Vertex pos="1.75 0.125 -0.25" />
                            <Vertex pos="1.75 -0.125 0.25" />
                            <Vertex pos="1.75 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white_doublevert" texgens="0 1 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 1.75" album="" material="bm_edge_white_doublevert" texgens="0 -1 0 -288 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_half" texgens="1 0 0 -1536 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="64 64">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_half" texgens="-1 0 0 1664 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="64 64">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="469" owner="0" type="0" pos="-10 119 17" rot="0 1 8.74228e-008 3.14159" scale="" transform="-1 5.2108e-015 0 -10 5.2108e-015 1 1.74846e-007 119 4.55543e-022 1.74846e-007 -1 17 0 0 0 1" group="-1" locked="0" nextFaceID="18" nextVertexID="18">
                        <Vertices>
                            <Vertex pos="-9.28213e-007 9.53674e-007 0.500001" />
                            <Vertex pos="0.46194 0.191342 -6.55651e-007" />
                            <Vertex pos="0.5 -1.78814e-007 -6.55651e-007" />
                            <Vertex pos="0.353553 0.353553 -6.55651e-007" />
                            <Vertex pos="0.191339 0.46194 -6.55651e-007" />
                            <Vertex pos="-1.66578e-006 0.5 -6.55651e-007" />
                            <Vertex pos="-0.191344 0.461939 -6.55651e-007" />
                            <Vertex pos="-0.353552 0.353555 -6.55651e-007" />
                            <Vertex pos="-0.461939 0.191343 -6.55651e-007" />
                            <Vertex pos="-0.5 1.3113e-006 -6.55651e-007" />
                            <Vertex pos="-0.46194 -0.191341 -6.55651e-007" />
                            <Vertex pos="-0.353554 -0.353553 -6.55651e-007" />
                            <Vertex pos="-0.191342 -0.46194 -6.55651e-007" />
                            <Vertex pos="4.60123e-007 -0.5 -6.55651e-007" />
                            <Vertex pos="0.191343 -0.461939 -6.55651e-007" />
                            <Vertex pos="0.353554 -0.353552 -6.55651e-007" />
                            <Vertex pos="0.46194 -0.19134 -6.55651e-007" />
                        </Vertices>
                        <Face id="0" plane="0.700215 0.13928 0.700214 -0.350107" album="Blasted" material="solid_bm_black" texgens="-0.195089 0.980785 0 3.12142 0.431839 0.0858975 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0.593612 0.396643 0.700213 -0.350107" album="Blasted" material="solid_bm_black" texgens="-0.555574 0.831467 0 9.36443 0.366094 0.244619 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 1 0" />
                        </Face>
                        <Face id="2" plane="0.396638 0.593616 0.700212 -0.350107" album="Blasted" material="solid_bm_black" texgens="-0.83147 0.555569 0 15.6073 0.244616 0.366095 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 3 0" />
                        </Face>
                        <Face id="3" plane="0.139282 0.700216 0.700213 -0.350108" album="Blasted" material="solid_bm_black" texgens="-0.980786 0.195089 0 21.8501 0.0858976 0.431839 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0" />
                        </Face>
                        <Face id="4" plane="-0.139284 0.700216 0.700212 -0.350108" album="Blasted" material="solid_bm_black" texgens="-0.980785 -0.195094 0 28.0931 -0.0858996 0.431839 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 5 0" />
                        </Face>
                        <Face id="5" plane="-0.396641 0.593614 0.700213 -0.350108" album="Blasted" material="solid_bm_black" texgens="-0.831469 -0.555571 0 34.3359 -0.244617 0.366096 -0.897851 -21.2751 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 0" />
                        </Face>
                        <Face id="6" plane="-0.593614 0.396642 0.700212 -0.350108" album="Blasted" material="solid_bm_black" texgens="-0.555572 -0.831469 0 40.5788 -0.366095 0.244618 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 8 7 0" />
                        </Face>
                        <Face id="7" plane="-0.700216 0.139284 0.700212 -0.350108" album="Blasted" material="solid_bm_black" texgens="-0.195094 -0.980785 0 46.8216 -0.431839 0.0858998 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 9 8 0" />
                        </Face>
                        <Face id="8" plane="-0.700216 -0.13928 0.700213 -0.350108" album="Blasted" material="solid_bm_black" texgens="0.195089 -0.980786 0 53.0645 -0.431839 -0.0858974 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 10 9 0" />
                        </Face>
                        <Face id="9" plane="-0.593615 -0.396639 0.700213 -0.350107" album="Blasted" material="solid_bm_black" texgens="0.555568 -0.831471 0 59.3073 -0.366096 -0.244616 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 11 10 0" />
                        </Face>
                        <Face id="10" plane="-0.396641 -0.593613 0.700214 -0.350107" album="Blasted" material="solid_bm_black" texgens="0.831469 -0.555571 0 65.5503 -0.244618 -0.366095 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 12 11 0" />
                        </Face>
                        <Face id="11" plane="-0.13928 -0.700215 0.700214 -0.350107" album="Blasted" material="solid_bm_black" texgens="0.980786 -0.195088 0 71.7932 -0.0858974 -0.43184 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 13 12 0" />
                        </Face>
                        <Face id="12" plane="0.139284 -0.700215 0.700214 -0.350107" album="Blasted" material="solid_bm_black" texgens="0.980785 0.195093 0 78.036 0.0858995 -0.431839 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 14 13 0" />
                        </Face>
                        <Face id="13" plane="0.396643 -0.593612 0.700214 -0.350107" album="Blasted" material="solid_bm_black" texgens="0.831467 0.555574 0 84.2792 0.244619 -0.366094 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 15 14 0" />
                        </Face>
                        <Face id="14" plane="0.593615 -0.396638 0.700214 -0.350107" album="Blasted" material="solid_bm_black" texgens="0.555568 0.831471 0 90.5221 0.366096 -0.244616 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 16 15 0" />
                        </Face>
                        <Face id="15" plane="0.700215 -0.139282 0.700214 -0.350107" album="Blasted" material="solid_bm_black" texgens="0.195091 0.980785 0 96.7649 0.431839 -0.0858984 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 16 0 2" />
                        </Face>
                        <Face id="16" plane="-0 0 -1 -6.55651e-007" album="Blasted" material="solid_bm_black" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 16 2 1 3 4 5 6 7 8 9 10 11 12 13 14 15" />
                        </Face>
                    </Brush>
                    <Brush id="470" owner="0" type="0" pos="-10 119 17.5" rot="1 0 0 0" scale="" transform="1 0 0 -10 0 1 0 119 0 0 1 17.5 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="0.46194 0.191342 -0.5" />
                            <Vertex pos="0.461941 0.191345 3.5" />
                            <Vertex pos="0.5 -1.2296e-007 -0.5" />
                            <Vertex pos="0.5 0 3.5" />
                            <Vertex pos="0.353553 0.353553 -0.5" />
                            <Vertex pos="0.353554 0.353554 3.5" />
                            <Vertex pos="0.19134 0.46194 -0.5" />
                            <Vertex pos="0.191341 0.461937 3.5" />
                            <Vertex pos="-1.86293e-006 0.5 -0.5" />
                            <Vertex pos="0 0.5 3.5" />
                            <Vertex pos="-0.191344 0.461939 -0.5" />
                            <Vertex pos="-0.191345 0.461937 3.5" />
                            <Vertex pos="-0.353552 0.353555 -0.5" />
                            <Vertex pos="-0.353554 0.353554 3.5" />
                            <Vertex pos="-0.461939 0.191343 -0.5" />
                            <Vertex pos="-0.461941 0.191345 3.5" />
                            <Vertex pos="-0.5 1.25189e-006 -0.5" />
                            <Vertex pos="-0.5 0 3.5" />
                            <Vertex pos="-0.46194 -0.191341 -0.5" />
                            <Vertex pos="-0.461941 -0.191338 3.5" />
                            <Vertex pos="-0.353554 -0.353553 -0.5" />
                            <Vertex pos="-0.353554 -0.353554 3.5" />
                            <Vertex pos="-0.191342 -0.46194 -0.5" />
                            <Vertex pos="-0.191341 -0.461937 3.5" />
                            <Vertex pos="4.28482e-007 -0.5 -0.5" />
                            <Vertex pos="0 -0.5 3.5" />
                            <Vertex pos="0.191343 -0.461939 -0.5" />
                            <Vertex pos="0.191341 -0.461937 3.5" />
                            <Vertex pos="0.353554 -0.353552 -0.5" />
                            <Vertex pos="0.353554 -0.353554 3.5" />
                            <Vertex pos="0.46194 -0.19134 -0.5" />
                            <Vertex pos="0.461941 -0.191338 3.5" />
                        </Vertices>
                        <Face id="0" plane="0.980787 0.195081 -3.95253e-007 -0.490392" album="Blasted" material="solid_bm_black" texgens="-0.195089 0.980786 0 3.12142 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.831467 0.555574 -3.51365e-007 -0.490393" album="Blasted" material="solid_bm_black" texgens="-0.555574 0.831467 0 9.36443 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.555569 0.83147 4.80827e-007 -0.490392" album="Blasted" material="solid_bm_black" texgens="-0.83147 0.555569 0 15.6073 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="0.195089 0.980786 -9.08593e-008 -0.490392" album="Blasted" material="solid_bm_black" texgens="-0.980786 0.195089 0 21.8501 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.195094 0.980785 4.40176e-007 -0.490392" album="Blasted" material="solid_bm_black" texgens="-0.980785 -0.195094 0 28.0931 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.55557 0.831469 -7.29019e-008 -0.490393" album="Blasted" material="solid_bm_black" texgens="-0.831469 -0.55557 0 34.3359 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="-0.831469 0.555572 -6.94465e-007 -0.490393" album="Blasted" material="solid_bm_black" texgens="-0.555572 -0.831469 0 40.5788 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="-0.980785 0.195094 6.10591e-008 -0.490392" album="Blasted" material="solid_bm_black" texgens="-0.195094 -0.980785 0 46.8216 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.980786 -0.195089 -1.02373e-007 -0.490393" album="Blasted" material="solid_bm_black" texgens="0.195089 -0.980786 0 53.0645 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.831471 -0.555568 -1.40736e-007 -0.490393" album="Blasted" material="solid_bm_black" texgens="0.555568 -0.831471 0 59.3073 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.555572 -0.831469 7.5816e-007 -0.490392" album="Blasted" material="solid_bm_black" texgens="0.831469 -0.555572 0 65.5502 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.195089 -0.980786 -2.0898e-008 -0.490393" album="Blasted" material="solid_bm_black" texgens="0.980786 -0.195088 0 71.7932 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="0.195093 -0.980785 5.86985e-007 -0.490392" album="Blasted" material="solid_bm_black" texgens="0.980785 0.195093 0 78.036 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="0.555574 -0.831467 -4.15059e-007 -0.490393" album="Blasted" material="solid_bm_black" texgens="0.831467 0.555574 0 84.2792 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="0.831471 -0.555568 6.67054e-008 -0.490392" album="Blasted" material="solid_bm_black" texgens="0.555568 0.831471 0 90.5221 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="0.980786 -0.195088 5.997e-009 -0.490393" album="Blasted" material="solid_bm_black" texgens="0.195091 0.980785 0 96.7649 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 3 2 30" />
                        </Face>
                        <Face id="16" plane="-0 0 -1 -0.5" album="Blasted" material="solid_bm_black" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 30 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28" />
                        </Face>
                        <Face id="17" plane="0 -0 1 -3.5" album="Blasted" material="solid_bm_black" texgens="1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="471" owner="0" type="0" pos="-8.5 47.875 20.25" rot="1 0 0 0" scale="" transform="1 0 0 -8.5 0 1 0 47.875 0 0 1 20.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.75 0.125 0.25" />
                            <Vertex pos="0.75 0.125 -0.25" />
                            <Vertex pos="0.75 -0.125 0.25" />
                            <Vertex pos="0.75 -0.125 -0.25" />
                            <Vertex pos="-3.75 0.125 0.25" />
                            <Vertex pos="-3.75 0.125 -0.25" />
                            <Vertex pos="-3.75 -0.125 0.25" />
                            <Vertex pos="-3.75 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.75" album="Blasted" material="bm_trim" texgens="0 1 0 12256 0 0 -1 -5184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.75" album="Blasted" material="bm_trim" texgens="0 -1 0 -12256 0 0 -1 -5184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_trim" texgens="-1 0 0 2176 0 0 -1 -5184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="Blasted" material="bm_trim" texgens="1 0 0 -2176 0 0 -1 -5184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 -2176 0 -1 0 -12256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 2176 0 -1 0 -12256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="472" owner="0" type="0" pos="-10 41 18.75" rot="0 1 8.74228e-008 3.14159" scale="" transform="-1 5.2108e-015 0 -10 5.2108e-015 1 1.74846e-007 41 4.55543e-022 1.74846e-007 -1 18.75 0 0 0 1" group="-1" locked="0" nextFaceID="18" nextVertexID="18">
                        <Vertices>
                            <Vertex pos="-9.28213e-007 9.53674e-007 0.500001" />
                            <Vertex pos="0.46194 0.191342 -6.55651e-007" />
                            <Vertex pos="0.5 -1.78814e-007 -6.55651e-007" />
                            <Vertex pos="0.353553 0.353553 -6.55651e-007" />
                            <Vertex pos="0.191339 0.46194 -6.55651e-007" />
                            <Vertex pos="-1.66578e-006 0.5 -6.55651e-007" />
                            <Vertex pos="-0.191344 0.461939 -6.55651e-007" />
                            <Vertex pos="-0.353552 0.353555 -6.55651e-007" />
                            <Vertex pos="-0.461939 0.191343 -6.55651e-007" />
                            <Vertex pos="-0.5 1.3113e-006 -6.55651e-007" />
                            <Vertex pos="-0.46194 -0.191341 -6.55651e-007" />
                            <Vertex pos="-0.353554 -0.353553 -6.55651e-007" />
                            <Vertex pos="-0.191342 -0.46194 -6.55651e-007" />
                            <Vertex pos="4.60123e-007 -0.5 -6.55651e-007" />
                            <Vertex pos="0.191343 -0.461939 -6.55651e-007" />
                            <Vertex pos="0.353554 -0.353552 -6.55651e-007" />
                            <Vertex pos="0.46194 -0.19134 -6.55651e-007" />
                        </Vertices>
                        <Face id="0" plane="0.700215 0.13928 0.700214 -0.350107" album="Blasted" material="metal_bm" texgens="-0.195089 0.980785 0 3.12142 0.431839 0.0858975 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0.593612 0.396643 0.700213 -0.350107" album="Blasted" material="metal_bm" texgens="-0.555574 0.831467 0 9.36443 0.366094 0.244619 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 1 0" />
                        </Face>
                        <Face id="2" plane="0.396638 0.593616 0.700212 -0.350107" album="Blasted" material="metal_bm" texgens="-0.83147 0.555569 0 15.6073 0.244616 0.366095 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 3 0" />
                        </Face>
                        <Face id="3" plane="0.139282 0.700216 0.700213 -0.350108" album="Blasted" material="metal_bm" texgens="-0.980786 0.195089 0 21.8501 0.0858976 0.431839 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0" />
                        </Face>
                        <Face id="4" plane="-0.139284 0.700216 0.700212 -0.350108" album="Blasted" material="metal_bm" texgens="-0.980785 -0.195094 0 28.0931 -0.0858996 0.431839 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 5 0" />
                        </Face>
                        <Face id="5" plane="-0.396641 0.593614 0.700213 -0.350108" album="Blasted" material="metal_bm" texgens="-0.831469 -0.555571 0 34.3359 -0.244617 0.366096 -0.897851 -21.2751 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 0" />
                        </Face>
                        <Face id="6" plane="-0.593614 0.396642 0.700212 -0.350108" album="Blasted" material="metal_bm" texgens="-0.555572 -0.831469 0 40.5788 -0.366095 0.244618 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 8 7 0" />
                        </Face>
                        <Face id="7" plane="-0.700216 0.139284 0.700212 -0.350108" album="Blasted" material="metal_bm" texgens="-0.195094 -0.980785 0 46.8216 -0.431839 0.0858998 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 9 8 0" />
                        </Face>
                        <Face id="8" plane="-0.700216 -0.13928 0.700213 -0.350108" album="Blasted" material="metal_bm" texgens="0.195089 -0.980786 0 53.0645 -0.431839 -0.0858974 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 10 9 0" />
                        </Face>
                        <Face id="9" plane="-0.593615 -0.396639 0.700213 -0.350107" album="Blasted" material="metal_bm" texgens="0.555568 -0.831471 0 59.3073 -0.366096 -0.244616 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 11 10 0" />
                        </Face>
                        <Face id="10" plane="-0.396641 -0.593613 0.700214 -0.350107" album="Blasted" material="metal_bm" texgens="0.831469 -0.555571 0 65.5503 -0.244618 -0.366095 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 12 11 0" />
                        </Face>
                        <Face id="11" plane="-0.13928 -0.700215 0.700214 -0.350107" album="Blasted" material="metal_bm" texgens="0.980786 -0.195088 0 71.7932 -0.0858974 -0.43184 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 13 12 0" />
                        </Face>
                        <Face id="12" plane="0.139284 -0.700215 0.700214 -0.350107" album="Blasted" material="metal_bm" texgens="0.980785 0.195093 0 78.036 0.0858995 -0.431839 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 14 13 0" />
                        </Face>
                        <Face id="13" plane="0.396643 -0.593612 0.700214 -0.350107" album="Blasted" material="metal_bm" texgens="0.831467 0.555574 0 84.2792 0.244619 -0.366094 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 15 14 0" />
                        </Face>
                        <Face id="14" plane="0.593615 -0.396638 0.700214 -0.350107" album="Blasted" material="metal_bm" texgens="0.555568 0.831471 0 90.5221 0.366096 -0.244616 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 16 15 0" />
                        </Face>
                        <Face id="15" plane="0.700215 -0.139282 0.700214 -0.350107" album="Blasted" material="metal_bm" texgens="0.195091 0.980785 0 96.7649 0.431839 -0.0858984 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 16 0 2" />
                        </Face>
                        <Face id="16" plane="-0 0 -1 -6.55651e-007" album="Blasted" material="metal_bm" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 16 2 1 3 4 5 6 7 8 9 10 11 12 13 14 15" />
                        </Face>
                    </Brush>
                    <Brush id="473" owner="0" type="0" pos="-10 41 17.25" rot="1 0 0 0" scale="" transform="1 0 0 -10 0 1 0 41 0 0 1 17.25 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="0.46194 0.191341 1.5" />
                            <Vertex pos="0.461941 0.191345 3.5" />
                            <Vertex pos="0.5 0 1.5" />
                            <Vertex pos="0.5 0 3.5" />
                            <Vertex pos="0.353553 0.353554 1.5" />
                            <Vertex pos="0.353554 0.353554 3.5" />
                            <Vertex pos="0.19134 0.461941 1.5" />
                            <Vertex pos="0.191341 0.461937 3.5" />
                            <Vertex pos="-1.90735e-006 0.5 1.5" />
                            <Vertex pos="0 0.5 3.5" />
                            <Vertex pos="-0.191344 0.461941 1.5" />
                            <Vertex pos="-0.191345 0.461937 3.5" />
                            <Vertex pos="-0.353552 0.353554 1.5" />
                            <Vertex pos="-0.353554 0.353554 3.5" />
                            <Vertex pos="-0.461939 0.191341 1.5" />
                            <Vertex pos="-0.461941 0.191345 3.5" />
                            <Vertex pos="-0.5 0 1.5" />
                            <Vertex pos="-0.5 0 3.5" />
                            <Vertex pos="-0.46194 -0.191341 1.5" />
                            <Vertex pos="-0.461941 -0.191338 3.5" />
                            <Vertex pos="-0.353554 -0.353554 1.5" />
                            <Vertex pos="-0.353554 -0.353554 3.5" />
                            <Vertex pos="-0.191342 -0.461941 1.5" />
                            <Vertex pos="-0.191341 -0.461937 3.5" />
                            <Vertex pos="0 -0.5 1.5" />
                            <Vertex pos="0 -0.5 3.5" />
                            <Vertex pos="0.191343 -0.461941 1.5" />
                            <Vertex pos="0.191341 -0.461937 3.5" />
                            <Vertex pos="0.353554 -0.353554 1.5" />
                            <Vertex pos="0.353554 -0.353554 3.5" />
                            <Vertex pos="0.46194 -0.191341 1.5" />
                            <Vertex pos="0.461941 -0.191338 3.5" />
                        </Vertices>
                        <Face id="0" plane="0.980787 0.195081 -8.87888e-007 -0.49039" album="Blasted" material="metal_bm" texgens="-0.195089 0.980786 0 3.12142 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.83147 0.555569 -4.21256e-007 -0.490392" album="Blasted" material="metal_bm" texgens="-0.555574 0.831467 0 9.36443 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.555569 0.83147 1.38291e-006 -0.490395" album="Blasted" material="metal_bm" texgens="-0.83147 0.555569 0 15.6073 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="0.195084 0.980787 -1.86047e-007 -0.490393" album="Blasted" material="metal_bm" texgens="-0.980786 0.195089 0 21.8501 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.195084 0.980787 1.85955e-006 -0.490396" album="Blasted" material="metal_bm" texgens="-0.980785 -0.195094 0 28.0931 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.555581 0.831462 -5.5468e-007 -0.490393" album="Blasted" material="metal_bm" texgens="-0.831469 -0.55557 0 34.3359 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="-0.83147 0.555569 -1.9436e-006 -0.490389" album="Blasted" material="metal_bm" texgens="-0.555572 -0.831469 0 40.5788 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="-0.980784 0.195095 0 -0.490392" album="Blasted" material="metal_bm" texgens="-0.195094 -0.980785 0 46.8216 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.980785 -0.19509 -2.04744e-007 -0.490392" album="Blasted" material="metal_bm" texgens="0.195089 -0.980786 0 53.0645 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.831473 -0.555566 0 -0.490393" album="Blasted" material="metal_bm" texgens="0.555568 -0.831471 0 59.3073 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.555572 -0.831469 1.93758e-006 -0.490397" album="Blasted" material="metal_bm" texgens="0.831469 -0.555572 0 65.5502 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.195084 -0.980787 0 -0.490393" album="Blasted" material="metal_bm" texgens="0.980786 -0.195088 0 71.7932 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="0.195083 -0.980787 2.15316e-006 -0.490397" album="Blasted" material="metal_bm" texgens="0.980785 0.195093 0 78.036 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="0.555574 -0.831467 0 -0.490394" album="Blasted" material="metal_bm" texgens="0.831467 0.555574 0 84.2792 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="0.831473 -0.555566 4.1074e-007 -0.490394" album="Blasted" material="metal_bm" texgens="0.555568 0.831471 0 90.5221 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="0.980786 -0.195088 0 -0.490393" album="Blasted" material="metal_bm" texgens="0.195091 0.980785 0 96.7649 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 3 2 30" />
                        </Face>
                        <Face id="16" plane="-0 0 -1 1.5" album="Blasted" material="metal_bm" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 30 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28" />
                        </Face>
                        <Face id="17" plane="0 -0 1 -3.5" album="Blasted" material="metal_bm" texgens="1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="475" owner="0" type="0" pos="-10 28 18.25" rot="0 1 8.74228e-008 3.14159" scale="" transform="-1 5.2108e-015 0 -10 5.2108e-015 1 1.74846e-007 28 4.55543e-022 1.74846e-007 -1 18.25 0 0 0 1" group="-1" locked="0" nextFaceID="18" nextVertexID="18">
                        <Vertices>
                            <Vertex pos="-9.28213e-007 9.53674e-007 0.500001" />
                            <Vertex pos="0.46194 0.191342 -6.55651e-007" />
                            <Vertex pos="0.5 -1.78814e-007 -6.55651e-007" />
                            <Vertex pos="0.353553 0.353553 -6.55651e-007" />
                            <Vertex pos="0.191339 0.46194 -6.55651e-007" />
                            <Vertex pos="-1.66578e-006 0.5 -6.55651e-007" />
                            <Vertex pos="-0.191344 0.461939 -6.55651e-007" />
                            <Vertex pos="-0.353552 0.353555 -6.55651e-007" />
                            <Vertex pos="-0.461939 0.191343 -6.55651e-007" />
                            <Vertex pos="-0.5 1.3113e-006 -6.55651e-007" />
                            <Vertex pos="-0.46194 -0.191341 -6.55651e-007" />
                            <Vertex pos="-0.353554 -0.353553 -6.55651e-007" />
                            <Vertex pos="-0.191342 -0.46194 -6.55651e-007" />
                            <Vertex pos="4.60123e-007 -0.5 -6.55651e-007" />
                            <Vertex pos="0.191343 -0.461939 -6.55651e-007" />
                            <Vertex pos="0.353554 -0.353552 -6.55651e-007" />
                            <Vertex pos="0.46194 -0.19134 -6.55651e-007" />
                        </Vertices>
                        <Face id="0" plane="0.700215 0.13928 0.700214 -0.350107" album="Blasted" material="metal_bm" texgens="-0.195089 0.980785 0 3.12142 0.431839 0.0858975 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0.593612 0.396643 0.700213 -0.350107" album="Blasted" material="metal_bm" texgens="-0.555574 0.831467 0 9.36443 0.366094 0.244619 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 1 0" />
                        </Face>
                        <Face id="2" plane="0.396638 0.593616 0.700212 -0.350107" album="Blasted" material="metal_bm" texgens="-0.83147 0.555569 0 15.6073 0.244616 0.366095 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 3 0" />
                        </Face>
                        <Face id="3" plane="0.139282 0.700216 0.700213 -0.350108" album="Blasted" material="metal_bm" texgens="-0.980786 0.195089 0 21.8501 0.0858976 0.431839 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0" />
                        </Face>
                        <Face id="4" plane="-0.139284 0.700216 0.700212 -0.350108" album="Blasted" material="metal_bm" texgens="-0.980785 -0.195094 0 28.0931 -0.0858996 0.431839 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 5 0" />
                        </Face>
                        <Face id="5" plane="-0.396641 0.593614 0.700213 -0.350108" album="Blasted" material="metal_bm" texgens="-0.831469 -0.555571 0 34.3359 -0.244617 0.366096 -0.897851 -21.2751 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 0" />
                        </Face>
                        <Face id="6" plane="-0.593614 0.396642 0.700212 -0.350108" album="Blasted" material="metal_bm" texgens="-0.555572 -0.831469 0 40.5788 -0.366095 0.244618 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 8 7 0" />
                        </Face>
                        <Face id="7" plane="-0.700216 0.139284 0.700212 -0.350108" album="Blasted" material="metal_bm" texgens="-0.195094 -0.980785 0 46.8216 -0.431839 0.0858998 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 9 8 0" />
                        </Face>
                        <Face id="8" plane="-0.700216 -0.13928 0.700213 -0.350108" album="Blasted" material="metal_bm" texgens="0.195089 -0.980786 0 53.0645 -0.431839 -0.0858974 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 10 9 0" />
                        </Face>
                        <Face id="9" plane="-0.593615 -0.396639 0.700213 -0.350107" album="Blasted" material="metal_bm" texgens="0.555568 -0.831471 0 59.3073 -0.366096 -0.244616 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 11 10 0" />
                        </Face>
                        <Face id="10" plane="-0.396641 -0.593613 0.700214 -0.350107" album="Blasted" material="metal_bm" texgens="0.831469 -0.555571 0 65.5503 -0.244618 -0.366095 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 12 11 0" />
                        </Face>
                        <Face id="11" plane="-0.13928 -0.700215 0.700214 -0.350107" album="Blasted" material="metal_bm" texgens="0.980786 -0.195088 0 71.7932 -0.0858974 -0.43184 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 13 12 0" />
                        </Face>
                        <Face id="12" plane="0.139284 -0.700215 0.700214 -0.350107" album="Blasted" material="metal_bm" texgens="0.980785 0.195093 0 78.036 0.0858995 -0.431839 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 14 13 0" />
                        </Face>
                        <Face id="13" plane="0.396643 -0.593612 0.700214 -0.350107" album="Blasted" material="metal_bm" texgens="0.831467 0.555574 0 84.2792 0.244619 -0.366094 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 15 14 0" />
                        </Face>
                        <Face id="14" plane="0.593615 -0.396638 0.700214 -0.350107" album="Blasted" material="metal_bm" texgens="0.555568 0.831471 0 90.5221 0.366096 -0.244616 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 16 15 0" />
                        </Face>
                        <Face id="15" plane="0.700215 -0.139282 0.700214 -0.350107" album="Blasted" material="metal_bm" texgens="0.195091 0.980785 0 96.7649 0.431839 -0.0858984 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 16 0 2" />
                        </Face>
                        <Face id="16" plane="-0 0 -1 -6.55651e-007" album="Blasted" material="metal_bm" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 16 2 1 3 4 5 6 7 8 9 10 11 12 13 14 15" />
                        </Face>
                    </Brush>
                    <Brush id="476" owner="0" type="0" pos="-10 28 16.75" rot="1 0 0 0" scale="" transform="1 0 0 -10 0 1 0 28 0 0 1 16.75 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="0.46194 0.191341 1.5" />
                            <Vertex pos="0.461941 0.191345 3.5" />
                            <Vertex pos="0.5 0 1.5" />
                            <Vertex pos="0.5 0 3.5" />
                            <Vertex pos="0.353553 0.353554 1.5" />
                            <Vertex pos="0.353554 0.353554 3.5" />
                            <Vertex pos="0.19134 0.461941 1.5" />
                            <Vertex pos="0.191341 0.461937 3.5" />
                            <Vertex pos="-1.90735e-006 0.5 1.5" />
                            <Vertex pos="0 0.5 3.5" />
                            <Vertex pos="-0.191344 0.461941 1.5" />
                            <Vertex pos="-0.191345 0.461937 3.5" />
                            <Vertex pos="-0.353552 0.353554 1.5" />
                            <Vertex pos="-0.353554 0.353554 3.5" />
                            <Vertex pos="-0.461939 0.191341 1.5" />
                            <Vertex pos="-0.461941 0.191345 3.5" />
                            <Vertex pos="-0.5 0 1.5" />
                            <Vertex pos="-0.5 0 3.5" />
                            <Vertex pos="-0.46194 -0.191341 1.5" />
                            <Vertex pos="-0.461941 -0.191338 3.5" />
                            <Vertex pos="-0.353554 -0.353554 1.5" />
                            <Vertex pos="-0.353554 -0.353554 3.5" />
                            <Vertex pos="-0.191342 -0.461941 1.5" />
                            <Vertex pos="-0.191341 -0.461937 3.5" />
                            <Vertex pos="0 -0.5 1.5" />
                            <Vertex pos="0 -0.5 3.5" />
                            <Vertex pos="0.191343 -0.461941 1.5" />
                            <Vertex pos="0.191341 -0.461937 3.5" />
                            <Vertex pos="0.353554 -0.353554 1.5" />
                            <Vertex pos="0.353554 -0.353554 3.5" />
                            <Vertex pos="0.46194 -0.191341 1.5" />
                            <Vertex pos="0.461941 -0.191338 3.5" />
                        </Vertices>
                        <Face id="0" plane="0.980787 0.195081 -8.87888e-007 -0.49039" album="Blasted" material="metal_bm" texgens="-0.195089 0.980786 0 3.12142 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.83147 0.555569 -4.21256e-007 -0.490392" album="Blasted" material="metal_bm" texgens="-0.555574 0.831467 0 9.36443 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.555569 0.83147 1.38291e-006 -0.490395" album="Blasted" material="metal_bm" texgens="-0.83147 0.555569 0 15.6073 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="0.195084 0.980787 -1.86047e-007 -0.490393" album="Blasted" material="metal_bm" texgens="-0.980786 0.195089 0 21.8501 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.195084 0.980787 1.85955e-006 -0.490396" album="Blasted" material="metal_bm" texgens="-0.980785 -0.195094 0 28.0931 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.555581 0.831462 -5.5468e-007 -0.490393" album="Blasted" material="metal_bm" texgens="-0.831469 -0.55557 0 34.3359 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="-0.83147 0.555569 -1.9436e-006 -0.490389" album="Blasted" material="metal_bm" texgens="-0.555572 -0.831469 0 40.5788 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="-0.980784 0.195095 0 -0.490392" album="Blasted" material="metal_bm" texgens="-0.195094 -0.980785 0 46.8216 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.980785 -0.19509 -2.04744e-007 -0.490392" album="Blasted" material="metal_bm" texgens="0.195089 -0.980786 0 53.0645 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.831473 -0.555566 0 -0.490393" album="Blasted" material="metal_bm" texgens="0.555568 -0.831471 0 59.3073 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.555572 -0.831469 1.93758e-006 -0.490397" album="Blasted" material="metal_bm" texgens="0.831469 -0.555572 0 65.5502 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.195084 -0.980787 0 -0.490393" album="Blasted" material="metal_bm" texgens="0.980786 -0.195088 0 71.7932 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="0.195083 -0.980787 2.15316e-006 -0.490397" album="Blasted" material="metal_bm" texgens="0.980785 0.195093 0 78.036 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="0.555574 -0.831467 0 -0.490394" album="Blasted" material="metal_bm" texgens="0.831467 0.555574 0 84.2792 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="0.831473 -0.555566 4.1074e-007 -0.490394" album="Blasted" material="metal_bm" texgens="0.555568 0.831471 0 90.5221 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="0.980786 -0.195088 0 -0.490393" album="Blasted" material="metal_bm" texgens="0.195091 0.980785 0 96.7649 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 3 2 30" />
                        </Face>
                        <Face id="16" plane="-0 0 -1 1.5" album="Blasted" material="metal_bm" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 30 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28" />
                        </Face>
                        <Face id="17" plane="0 -0 1 -3.5" album="Blasted" material="metal_bm" texgens="1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="477" owner="0" type="0" pos="-52 28 17.25" rot="0 1 8.74228e-008 3.14159" scale="" transform="-1 5.2108e-015 0 -52 5.2108e-015 1 1.74846e-007 28 4.55543e-022 1.74846e-007 -1 17.25 0 0 0 1" group="-1" locked="0" nextFaceID="18" nextVertexID="18">
                        <Vertices>
                            <Vertex pos="-9.28213e-007 9.53674e-007 0.500001" />
                            <Vertex pos="0.46194 0.191342 -6.55651e-007" />
                            <Vertex pos="0.5 -1.78814e-007 -6.55651e-007" />
                            <Vertex pos="0.353553 0.353553 -6.55651e-007" />
                            <Vertex pos="0.191339 0.46194 -6.55651e-007" />
                            <Vertex pos="-1.66578e-006 0.5 -6.55651e-007" />
                            <Vertex pos="-0.191344 0.461939 -6.55651e-007" />
                            <Vertex pos="-0.353552 0.353555 -6.55651e-007" />
                            <Vertex pos="-0.461939 0.191343 -6.55651e-007" />
                            <Vertex pos="-0.5 1.3113e-006 -6.55651e-007" />
                            <Vertex pos="-0.46194 -0.191341 -6.55651e-007" />
                            <Vertex pos="-0.353554 -0.353553 -6.55651e-007" />
                            <Vertex pos="-0.191342 -0.46194 -6.55651e-007" />
                            <Vertex pos="4.60123e-007 -0.5 -6.55651e-007" />
                            <Vertex pos="0.191343 -0.461939 -6.55651e-007" />
                            <Vertex pos="0.353554 -0.353552 -6.55651e-007" />
                            <Vertex pos="0.46194 -0.19134 -6.55651e-007" />
                        </Vertices>
                        <Face id="0" plane="0.700215 0.13928 0.700214 -0.350107" album="Blasted" material="metal_bm" texgens="-0.195089 0.980785 0 3.12142 0.431839 0.0858975 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0.593612 0.396643 0.700213 -0.350107" album="Blasted" material="metal_bm" texgens="-0.555574 0.831467 0 9.36443 0.366094 0.244619 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 1 0" />
                        </Face>
                        <Face id="2" plane="0.396638 0.593616 0.700212 -0.350107" album="Blasted" material="metal_bm" texgens="-0.83147 0.555569 0 15.6073 0.244616 0.366095 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 3 0" />
                        </Face>
                        <Face id="3" plane="0.139282 0.700216 0.700213 -0.350108" album="Blasted" material="metal_bm" texgens="-0.980786 0.195089 0 21.8501 0.0858976 0.431839 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0" />
                        </Face>
                        <Face id="4" plane="-0.139284 0.700216 0.700212 -0.350108" album="Blasted" material="metal_bm" texgens="-0.980785 -0.195094 0 28.0931 -0.0858996 0.431839 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 5 0" />
                        </Face>
                        <Face id="5" plane="-0.396641 0.593614 0.700213 -0.350108" album="Blasted" material="metal_bm" texgens="-0.831469 -0.555571 0 34.3359 -0.244617 0.366096 -0.897851 -21.2751 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 0" />
                        </Face>
                        <Face id="6" plane="-0.593614 0.396642 0.700212 -0.350108" album="Blasted" material="metal_bm" texgens="-0.555572 -0.831469 0 40.5788 -0.366095 0.244618 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 8 7 0" />
                        </Face>
                        <Face id="7" plane="-0.700216 0.139284 0.700212 -0.350108" album="Blasted" material="metal_bm" texgens="-0.195094 -0.980785 0 46.8216 -0.431839 0.0858998 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 9 8 0" />
                        </Face>
                        <Face id="8" plane="-0.700216 -0.13928 0.700213 -0.350108" album="Blasted" material="metal_bm" texgens="0.195089 -0.980786 0 53.0645 -0.431839 -0.0858974 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 10 9 0" />
                        </Face>
                        <Face id="9" plane="-0.593615 -0.396639 0.700213 -0.350107" album="Blasted" material="metal_bm" texgens="0.555568 -0.831471 0 59.3073 -0.366096 -0.244616 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 11 10 0" />
                        </Face>
                        <Face id="10" plane="-0.396641 -0.593613 0.700214 -0.350107" album="Blasted" material="metal_bm" texgens="0.831469 -0.555571 0 65.5503 -0.244618 -0.366095 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 12 11 0" />
                        </Face>
                        <Face id="11" plane="-0.13928 -0.700215 0.700214 -0.350107" album="Blasted" material="metal_bm" texgens="0.980786 -0.195088 0 71.7932 -0.0858974 -0.43184 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 13 12 0" />
                        </Face>
                        <Face id="12" plane="0.139284 -0.700215 0.700214 -0.350107" album="Blasted" material="metal_bm" texgens="0.980785 0.195093 0 78.036 0.0858995 -0.431839 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 14 13 0" />
                        </Face>
                        <Face id="13" plane="0.396643 -0.593612 0.700214 -0.350107" album="Blasted" material="metal_bm" texgens="0.831467 0.555574 0 84.2792 0.244619 -0.366094 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 15 14 0" />
                        </Face>
                        <Face id="14" plane="0.593615 -0.396638 0.700214 -0.350107" album="Blasted" material="metal_bm" texgens="0.555568 0.831471 0 90.5221 0.366096 -0.244616 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 16 15 0" />
                        </Face>
                        <Face id="15" plane="0.700215 -0.139282 0.700214 -0.350107" album="Blasted" material="metal_bm" texgens="0.195091 0.980785 0 96.7649 0.431839 -0.0858984 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 16 0 2" />
                        </Face>
                        <Face id="16" plane="-0 0 -1 -6.55651e-007" album="Blasted" material="metal_bm" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 16 2 1 3 4 5 6 7 8 9 10 11 12 13 14 15" />
                        </Face>
                    </Brush>
                    <Brush id="478" owner="0" type="0" pos="-52 28 15.75" rot="1 0 0 0" scale="" transform="1 0 0 -52 0 1 0 28 0 0 1 15.75 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="0.46194 0.191341 1.5" />
                            <Vertex pos="0.461941 0.191345 3.5" />
                            <Vertex pos="0.5 0 1.5" />
                            <Vertex pos="0.5 0 3.5" />
                            <Vertex pos="0.353553 0.353554 1.5" />
                            <Vertex pos="0.353554 0.353554 3.5" />
                            <Vertex pos="0.19134 0.461941 1.5" />
                            <Vertex pos="0.191341 0.461937 3.5" />
                            <Vertex pos="-1.90735e-006 0.5 1.5" />
                            <Vertex pos="0 0.5 3.5" />
                            <Vertex pos="-0.191344 0.461941 1.5" />
                            <Vertex pos="-0.191345 0.461937 3.5" />
                            <Vertex pos="-0.353552 0.353554 1.5" />
                            <Vertex pos="-0.353554 0.353554 3.5" />
                            <Vertex pos="-0.461939 0.191341 1.5" />
                            <Vertex pos="-0.461941 0.191345 3.5" />
                            <Vertex pos="-0.5 0 1.5" />
                            <Vertex pos="-0.5 0 3.5" />
                            <Vertex pos="-0.46194 -0.191341 1.5" />
                            <Vertex pos="-0.461941 -0.191338 3.5" />
                            <Vertex pos="-0.353554 -0.353554 1.5" />
                            <Vertex pos="-0.353554 -0.353554 3.5" />
                            <Vertex pos="-0.191342 -0.461941 1.5" />
                            <Vertex pos="-0.191341 -0.461937 3.5" />
                            <Vertex pos="0 -0.5 1.5" />
                            <Vertex pos="0 -0.5 3.5" />
                            <Vertex pos="0.191343 -0.461941 1.5" />
                            <Vertex pos="0.191341 -0.461937 3.5" />
                            <Vertex pos="0.353554 -0.353554 1.5" />
                            <Vertex pos="0.353554 -0.353554 3.5" />
                            <Vertex pos="0.46194 -0.191341 1.5" />
                            <Vertex pos="0.461941 -0.191338 3.5" />
                        </Vertices>
                        <Face id="0" plane="0.980787 0.195081 -8.87888e-007 -0.49039" album="Blasted" material="metal_bm" texgens="-0.195089 0.980786 0 3.12142 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.83147 0.555569 -4.21256e-007 -0.490392" album="Blasted" material="metal_bm" texgens="-0.555574 0.831467 0 9.36443 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.555569 0.83147 1.38291e-006 -0.490395" album="Blasted" material="metal_bm" texgens="-0.83147 0.555569 0 15.6073 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="0.195084 0.980787 -1.86047e-007 -0.490393" album="Blasted" material="metal_bm" texgens="-0.980786 0.195089 0 21.8501 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.195084 0.980787 1.85955e-006 -0.490396" album="Blasted" material="metal_bm" texgens="-0.980785 -0.195094 0 28.0931 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.555581 0.831462 -5.5468e-007 -0.490393" album="Blasted" material="metal_bm" texgens="-0.831469 -0.55557 0 34.3359 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="-0.83147 0.555569 -1.9436e-006 -0.490389" album="Blasted" material="metal_bm" texgens="-0.555572 -0.831469 0 40.5788 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="-0.980784 0.195095 0 -0.490392" album="Blasted" material="metal_bm" texgens="-0.195094 -0.980785 0 46.8216 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.980785 -0.19509 -2.04744e-007 -0.490392" album="Blasted" material="metal_bm" texgens="0.195089 -0.980786 0 53.0645 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.831473 -0.555566 0 -0.490393" album="Blasted" material="metal_bm" texgens="0.555568 -0.831471 0 59.3073 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.555572 -0.831469 1.93758e-006 -0.490397" album="Blasted" material="metal_bm" texgens="0.831469 -0.555572 0 65.5502 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.195084 -0.980787 0 -0.490393" album="Blasted" material="metal_bm" texgens="0.980786 -0.195088 0 71.7932 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="0.195083 -0.980787 2.15316e-006 -0.490397" album="Blasted" material="metal_bm" texgens="0.980785 0.195093 0 78.036 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="0.555574 -0.831467 0 -0.490394" album="Blasted" material="metal_bm" texgens="0.831467 0.555574 0 84.2792 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="0.831473 -0.555566 4.1074e-007 -0.490394" album="Blasted" material="metal_bm" texgens="0.555568 0.831471 0 90.5221 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="0.980786 -0.195088 0 -0.490393" album="Blasted" material="metal_bm" texgens="0.195091 0.980785 0 96.7649 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 3 2 30" />
                        </Face>
                        <Face id="16" plane="-0 0 -1 1.5" album="Blasted" material="metal_bm" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 30 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28" />
                        </Face>
                        <Face id="17" plane="0 -0 1 -3.5" album="Blasted" material="metal_bm" texgens="1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="479" owner="0" type="0" pos="-52 15 16.75" rot="0 1 8.74228e-008 3.14159" scale="" transform="-1 5.2108e-015 0 -52 5.2108e-015 1 1.74846e-007 15 4.55543e-022 1.74846e-007 -1 16.75 0 0 0 1" group="-1" locked="0" nextFaceID="18" nextVertexID="18">
                        <Vertices>
                            <Vertex pos="-9.28213e-007 9.53674e-007 0.500001" />
                            <Vertex pos="0.46194 0.191342 -6.55651e-007" />
                            <Vertex pos="0.5 -1.78814e-007 -6.55651e-007" />
                            <Vertex pos="0.353553 0.353553 -6.55651e-007" />
                            <Vertex pos="0.191339 0.46194 -6.55651e-007" />
                            <Vertex pos="-1.66578e-006 0.5 -6.55651e-007" />
                            <Vertex pos="-0.191344 0.461939 -6.55651e-007" />
                            <Vertex pos="-0.353552 0.353555 -6.55651e-007" />
                            <Vertex pos="-0.461939 0.191343 -6.55651e-007" />
                            <Vertex pos="-0.5 1.3113e-006 -6.55651e-007" />
                            <Vertex pos="-0.46194 -0.191341 -6.55651e-007" />
                            <Vertex pos="-0.353554 -0.353553 -6.55651e-007" />
                            <Vertex pos="-0.191342 -0.46194 -6.55651e-007" />
                            <Vertex pos="4.60123e-007 -0.5 -6.55651e-007" />
                            <Vertex pos="0.191343 -0.461939 -6.55651e-007" />
                            <Vertex pos="0.353554 -0.353552 -6.55651e-007" />
                            <Vertex pos="0.46194 -0.19134 -6.55651e-007" />
                        </Vertices>
                        <Face id="0" plane="0.700215 0.13928 0.700214 -0.350107" album="Blasted" material="metal_bm" texgens="-0.195089 0.980785 0 3.12142 0.431839 0.0858975 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0.593612 0.396643 0.700213 -0.350107" album="Blasted" material="metal_bm" texgens="-0.555574 0.831467 0 9.36443 0.366094 0.244619 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 1 0" />
                        </Face>
                        <Face id="2" plane="0.396638 0.593616 0.700212 -0.350107" album="Blasted" material="metal_bm" texgens="-0.83147 0.555569 0 15.6073 0.244616 0.366095 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 3 0" />
                        </Face>
                        <Face id="3" plane="0.139282 0.700216 0.700213 -0.350108" album="Blasted" material="metal_bm" texgens="-0.980786 0.195089 0 21.8501 0.0858976 0.431839 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0" />
                        </Face>
                        <Face id="4" plane="-0.139284 0.700216 0.700212 -0.350108" album="Blasted" material="metal_bm" texgens="-0.980785 -0.195094 0 28.0931 -0.0858996 0.431839 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 5 0" />
                        </Face>
                        <Face id="5" plane="-0.396641 0.593614 0.700213 -0.350108" album="Blasted" material="metal_bm" texgens="-0.831469 -0.555571 0 34.3359 -0.244617 0.366096 -0.897851 -21.2751 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 0" />
                        </Face>
                        <Face id="6" plane="-0.593614 0.396642 0.700212 -0.350108" album="Blasted" material="metal_bm" texgens="-0.555572 -0.831469 0 40.5788 -0.366095 0.244618 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 8 7 0" />
                        </Face>
                        <Face id="7" plane="-0.700216 0.139284 0.700212 -0.350108" album="Blasted" material="metal_bm" texgens="-0.195094 -0.980785 0 46.8216 -0.431839 0.0858998 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 9 8 0" />
                        </Face>
                        <Face id="8" plane="-0.700216 -0.13928 0.700213 -0.350108" album="Blasted" material="metal_bm" texgens="0.195089 -0.980786 0 53.0645 -0.431839 -0.0858974 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 10 9 0" />
                        </Face>
                        <Face id="9" plane="-0.593615 -0.396639 0.700213 -0.350107" album="Blasted" material="metal_bm" texgens="0.555568 -0.831471 0 59.3073 -0.366096 -0.244616 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 11 10 0" />
                        </Face>
                        <Face id="10" plane="-0.396641 -0.593613 0.700214 -0.350107" album="Blasted" material="metal_bm" texgens="0.831469 -0.555571 0 65.5503 -0.244618 -0.366095 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 12 11 0" />
                        </Face>
                        <Face id="11" plane="-0.13928 -0.700215 0.700214 -0.350107" album="Blasted" material="metal_bm" texgens="0.980786 -0.195088 0 71.7932 -0.0858974 -0.43184 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 13 12 0" />
                        </Face>
                        <Face id="12" plane="0.139284 -0.700215 0.700214 -0.350107" album="Blasted" material="metal_bm" texgens="0.980785 0.195093 0 78.036 0.0858995 -0.431839 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 14 13 0" />
                        </Face>
                        <Face id="13" plane="0.396643 -0.593612 0.700214 -0.350107" album="Blasted" material="metal_bm" texgens="0.831467 0.555574 0 84.2792 0.244619 -0.366094 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 15 14 0" />
                        </Face>
                        <Face id="14" plane="0.593615 -0.396638 0.700214 -0.350107" album="Blasted" material="metal_bm" texgens="0.555568 0.831471 0 90.5221 0.366096 -0.244616 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 16 15 0" />
                        </Face>
                        <Face id="15" plane="0.700215 -0.139282 0.700214 -0.350107" album="Blasted" material="metal_bm" texgens="0.195091 0.980785 0 96.7649 0.431839 -0.0858984 -0.897851 -21.275 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 16 0 2" />
                        </Face>
                        <Face id="16" plane="-0 0 -1 -6.55651e-007" album="Blasted" material="metal_bm" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 16 2 1 3 4 5 6 7 8 9 10 11 12 13 14 15" />
                        </Face>
                    </Brush>
                    <Brush id="480" owner="0" type="0" pos="-52 15 15.25" rot="1 0 0 0" scale="" transform="1 0 0 -52 0 1 0 15 0 0 1 15.25 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="0.46194 0.191341 1.5" />
                            <Vertex pos="0.461941 0.191345 3.5" />
                            <Vertex pos="0.5 0 1.5" />
                            <Vertex pos="0.5 0 3.5" />
                            <Vertex pos="0.353553 0.353554 1.5" />
                            <Vertex pos="0.353554 0.353554 3.5" />
                            <Vertex pos="0.19134 0.461941 1.5" />
                            <Vertex pos="0.191341 0.461937 3.5" />
                            <Vertex pos="-1.90735e-006 0.5 1.5" />
                            <Vertex pos="0 0.5 3.5" />
                            <Vertex pos="-0.191344 0.461941 1.5" />
                            <Vertex pos="-0.191345 0.461937 3.5" />
                            <Vertex pos="-0.353552 0.353554 1.5" />
                            <Vertex pos="-0.353554 0.353554 3.5" />
                            <Vertex pos="-0.461939 0.191341 1.5" />
                            <Vertex pos="-0.461941 0.191345 3.5" />
                            <Vertex pos="-0.5 0 1.5" />
                            <Vertex pos="-0.5 0 3.5" />
                            <Vertex pos="-0.46194 -0.191341 1.5" />
                            <Vertex pos="-0.461941 -0.191338 3.5" />
                            <Vertex pos="-0.353554 -0.353554 1.5" />
                            <Vertex pos="-0.353554 -0.353554 3.5" />
                            <Vertex pos="-0.191342 -0.461941 1.5" />
                            <Vertex pos="-0.191341 -0.461937 3.5" />
                            <Vertex pos="0 -0.5 1.5" />
                            <Vertex pos="0 -0.5 3.5" />
                            <Vertex pos="0.191343 -0.461941 1.5" />
                            <Vertex pos="0.191341 -0.461937 3.5" />
                            <Vertex pos="0.353554 -0.353554 1.5" />
                            <Vertex pos="0.353554 -0.353554 3.5" />
                            <Vertex pos="0.46194 -0.191341 1.5" />
                            <Vertex pos="0.461941 -0.191338 3.5" />
                        </Vertices>
                        <Face id="0" plane="0.980787 0.195081 -8.87888e-007 -0.49039" album="Blasted" material="metal_bm" texgens="-0.195089 0.980786 0 3.12142 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.83147 0.555569 -4.21256e-007 -0.490392" album="Blasted" material="metal_bm" texgens="-0.555574 0.831467 0 9.36443 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.555569 0.83147 1.38291e-006 -0.490395" album="Blasted" material="metal_bm" texgens="-0.83147 0.555569 0 15.6073 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="0.195084 0.980787 -1.86047e-007 -0.490393" album="Blasted" material="metal_bm" texgens="-0.980786 0.195089 0 21.8501 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.195084 0.980787 1.85955e-006 -0.490396" album="Blasted" material="metal_bm" texgens="-0.980785 -0.195094 0 28.0931 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.555581 0.831462 -5.5468e-007 -0.490393" album="Blasted" material="metal_bm" texgens="-0.831469 -0.55557 0 34.3359 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="-0.83147 0.555569 -1.9436e-006 -0.490389" album="Blasted" material="metal_bm" texgens="-0.555572 -0.831469 0 40.5788 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="-0.980784 0.195095 0 -0.490392" album="Blasted" material="metal_bm" texgens="-0.195094 -0.980785 0 46.8216 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.980785 -0.19509 -2.04744e-007 -0.490392" album="Blasted" material="metal_bm" texgens="0.195089 -0.980786 0 53.0645 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.831473 -0.555566 0 -0.490393" album="Blasted" material="metal_bm" texgens="0.555568 -0.831471 0 59.3073 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.555572 -0.831469 1.93758e-006 -0.490397" album="Blasted" material="metal_bm" texgens="0.831469 -0.555572 0 65.5502 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.195084 -0.980787 0 -0.490393" album="Blasted" material="metal_bm" texgens="0.980786 -0.195088 0 71.7932 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="0.195083 -0.980787 2.15316e-006 -0.490397" album="Blasted" material="metal_bm" texgens="0.980785 0.195093 0 78.036 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="0.555574 -0.831467 0 -0.490394" album="Blasted" material="metal_bm" texgens="0.831467 0.555574 0 84.2792 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="0.831473 -0.555566 4.1074e-007 -0.490394" album="Blasted" material="metal_bm" texgens="0.555568 0.831471 0 90.5221 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="0.980786 -0.195088 0 -0.490393" album="Blasted" material="metal_bm" texgens="0.195091 0.980785 0 96.7649 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 3 2 30" />
                        </Face>
                        <Face id="16" plane="-0 0 -1 1.5" album="Blasted" material="metal_bm" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 30 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28" />
                        </Face>
                        <Face id="17" plane="0 -0 1 -3.5" album="Blasted" material="metal_bm" texgens="1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="481" owner="0" type="0" pos="-7.875 56 20.25" rot="1 0 0 0" scale="" transform="1 0 0 -7.875 0 1 0 56 0 0 1 20.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 4 0.25" />
                            <Vertex pos="0.125 4 -0.25" />
                            <Vertex pos="0.125 -8 0.25" />
                            <Vertex pos="0.125 -8 -0.25" />
                            <Vertex pos="-0.125 4 0.25" />
                            <Vertex pos="-0.125 4 -0.25" />
                            <Vertex pos="-0.125 -8 0.25" />
                            <Vertex pos="-0.125 -8 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white" texgens="0 1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white" texgens="0 -1 0 -1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublevert" texgens="1 0 0 32 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="482" owner="0" type="0" pos="-12.125 151 20.25" rot="1 0 0 0" scale="" transform="1 0 0 -12.125 0 1 0 151 0 0 1 20.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 8 0.25" />
                            <Vertex pos="0.125 8 -0.25" />
                            <Vertex pos="0.125 -4 0.25" />
                            <Vertex pos="0.125 -4 -0.25" />
                            <Vertex pos="-0.125 8 0.25" />
                            <Vertex pos="-0.125 8 -0.25" />
                            <Vertex pos="-0.125 -4 0.25" />
                            <Vertex pos="-0.125 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white" texgens="0 1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white" texgens="0 -1 0 -1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white_doublevert" texgens="1 0 0 32 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="483" owner="0" type="0" pos="24.125 -39.5 20.25" rot="1 0 0 0" scale="" transform="1 0 0 24.125 0 1 0 -39.5 0 0 1 20.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 8 1.75" />
                            <Vertex pos="0.125 8 -0.75" />
                            <Vertex pos="0.125 7.5 1.75" />
                            <Vertex pos="0.125 7.5 -0.75" />
                            <Vertex pos="-0.125 8 1.75" />
                            <Vertex pos="-0.125 8 -0.75" />
                            <Vertex pos="-0.125 7.5 1.75" />
                            <Vertex pos="-0.125 7.5 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_edge_white" texgens="0 1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_edge_white" texgens="0 -1 0 -1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 7.5" album="" material="bm_edge_white_doublevert" texgens="1 0 0 -352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.75" album="" material="bm_edge_white_doublevert" texgens="1 0 0 32 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.75" album="" material="bm_edge_white_doublevert" texgens="-1 0 0 96 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="486" owner="0" type="0" pos="11.5 -28.5 21.25" rot="1 0 0 0" scale="" transform="1 0 0 11.5 0 1 0 -28.5 0 0 1 21.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12.5 -3 -1.75" />
                            <Vertex pos="12.5 -3 -2.25" />
                            <Vertex pos="12.5 -3.5 -1.75" />
                            <Vertex pos="12.5 -3.5 -2.25" />
                            <Vertex pos="6.5 -3 0.25" />
                            <Vertex pos="6.5 -3 -0.25" />
                            <Vertex pos="6.5 -3.5 0.25" />
                            <Vertex pos="6.5 -3.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12.5" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 6.5" album="" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3" album="" material="bm_edge_white" texgens="-1 0 0 1792 -0.333333 0 -1 618.666 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3.5" album="" material="bm_edge_white" texgens="1 0 0 1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.316228 0 0.948683 -2.29265" album="" material="bm_edge_white" texgens="1 0 0 1792 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.316228 0 -0.948683 1.81831" album="" material="bm_edge_white" texgens="-1 0 0 1408 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
